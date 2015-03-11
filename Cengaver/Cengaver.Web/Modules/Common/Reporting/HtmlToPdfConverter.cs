using Serenity.IO;

namespace Serenity.Web
{
    using Serenity.Console;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Web.Hosting;

    public class HtmlToPdfConverter
    {
        public string Url { get; set; }
        public List<string> AdditionalUrls { get; set; }
        public Dictionary<string, string> Cookies { get; set; }

        public int TimeoutSeconds { get; set; }
        public bool UsePrintMediaType { get; set; }
        public string UtilityExePath { get; set; }

        public HtmlToPdfConverter()
        {
            AdditionalUrls = new List<string>();
            Cookies = new Dictionary<string, string>();
            TimeoutSeconds = 300;
            UsePrintMediaType = true;
        }

        public byte[] Execute()
        {
            var exePath = UtilityExePath ?? HostingEnvironment.MapPath("~/Reports/Utility/wkhtmltopdf.exe");
            if (!File.Exists(exePath))
                throw new InvalidOperationException(String.Format("PDF üretimi için gereken wkhtmltopdf.exe dosyası '{0}' konumunda bulunamadı'", exePath));

            if (String.IsNullOrEmpty(this.Url))
                throw new ArgumentNullException("url");

            var args = new List<string>();

            if (UsePrintMediaType)
                args.Add("--print-media-type");
            else
                args.Add("--no-print-media-type");

            foreach (var cookie in Cookies)
            {
                args.Add("--cookie");
                args.Add(cookie.Key);
                args.Add(cookie.Value);
            }

            args.Add(this.Url);
            foreach (var additional in AdditionalUrls)
                args.Add(additional);

            var tempFile = Path.GetTempFileName();
            try
            {
                args.Add(tempFile);

                var process = new Process 
                { 
                    StartInfo = new ProcessStartInfo(exePath, CommandLineTools.EscapeArguments(args.ToArray()))
                    {
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                if (!process.Start())
                    throw new InvalidOperationException("PDF üretim programı başlatılırken hata oluştu!");

                if (!process.WaitForExit(TimeoutSeconds * 1000)) // max 300 sn de üretmeli
                    throw new InvalidOperationException("PDF üretilirken zaman aşımı oluştu!");

                if (process.ExitCode != 0 && process.ExitCode != 1)
                    throw new InvalidOperationException(String.Format("PDF üretim programı {0} hata kodu döndürdü!", process.ExitCode));

                if (!File.Exists(tempFile))
                    throw new InvalidOperationException("PDF üretimi sonrasında geçici dosya bulunamadı!");

                var bytes = File.ReadAllBytes(tempFile);
                if (bytes.Length == 0)
                    throw new InvalidOperationException("Üretilen PDF dosyası boş!");

                return bytes;
            }
            finally
            {
                TemporaryFileHelper.TryDelete(tempFile);
            }
        }
    }
}