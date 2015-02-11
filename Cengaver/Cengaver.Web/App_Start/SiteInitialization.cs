namespace Cengaver
{
    using FluentMigrator.Runner.Announcers;
    using FluentMigrator.Runner.Initialization;
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.Data;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.IO;
    using System.Web.Hosting;

    public static partial class SiteInitialization
    {
        public static SiteSetting PublicSiteSetting = new SiteSetting()
        {
            ThemeName = "meca",
            SliderByPageName = new Dictionary<string, Slider>()
            {
                { "PublicMainPage",new Slider(){ Items=new List<SliderItem>()
                    { 
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-1.jpg", Name="ev-elektronigi-Televizyon-1.jpg",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-2.jpg", Name="ev-elektronigi-Televizyon-2.jpg",Title="Olağanüstü etkileyicilik için kavisli 4K UHD TV ", Description="4K ayrıntılar, hassas kavisli ekran ve surround sesi bir araya getiren bu 4K UHD kavisli TV, TV izleme deneyiminizi değiştirecek." },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-3.jpg", Name="ev-elektronigi-Televizyon-3.jpg",Title="  BRAVIA® X85B 4K UHD TV  ", Description="Gelmiş geçmiş en güzel görüntü" },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-4.jpg", Name="ev-elektronigi-Televizyon-4.jpg",Title="  BRAVIA® X85B 4K UHD TV  ", Description="Gelmiş geçmiş en güzel görüntü" },

                        new SliderItem (){ FilePath= "~/content/images/slider/Telefon-1.jpeg", Name="Telefon-1.jpeg",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },
                        new SliderItem (){ FilePath= "~/content/images/slider/Telefon-2.jpeg", Name="Telefon-2.jpeg",Title="Olağanüstü etkileyicilik için kavisli 4K UHD TV ", Description="4K ayrıntılar, hassas kavisli ekran ve surround sesi bir araya getiren bu 4K UHD kavisli TV, TV izleme deneyiminizi değiştirecek." },
                        new SliderItem (){ FilePath= "~/content/images/slider/Telefon-3.jpeg", Name="Telefon-3.jpeg",Title="  BRAVIA® X85B 4K UHD TV  ", Description="Gelmiş geçmiş en güzel görüntü" },

                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Ses-Sistemleri-1.jpg", Name="ev-elektronigi-Ses-Sistemleri-1.jpg",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Ses-Sistemleri-2.jpg", Name="ev-elektronigi-Ses-Sistemleri-2.jpg",Title="Olağanüstü etkileyicilik için kavisli 4K UHD TV ", Description="4K ayrıntılar, hassas kavisli ekran ve surround sesi bir araya getiren bu 4K UHD kavisli TV, TV izleme deneyiminizi değiştirecek." },

                        new SliderItem (){ FilePath= "~/content/images/slider/Bilgisayar-Tablet-bilgisayar-1.png", Name="Bilgisayar-Tablet-bilgisayar-1.png",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },

                    }
                }},
                { "PublicComputerPage",new Slider(){ Items=new List<SliderItem>()
                    { 
                        new SliderItem (){ FilePath= "~/content/images/slider/Bilgisayar-Tablet-bilgisayar-1.png", Name="Bilgisayar-Tablet-bilgisayar-1.png",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },
                    }
                }},
                { "PublicHomeElectronicPage",new Slider(){ Items=new List<SliderItem>()
                    { 
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-1.jpg", Name="ev-elektronigi-Televizyon-1.jpg",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-2.jpg", Name="ev-elektronigi-Televizyon-2.jpg",Title="Olağanüstü etkileyicilik için kavisli 4K UHD TV ", Description="4K ayrıntılar, hassas kavisli ekran ve surround sesi bir araya getiren bu 4K UHD kavisli TV, TV izleme deneyiminizi değiştirecek." },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-3.jpg", Name="ev-elektronigi-Televizyon-3.jpg",Title="  BRAVIA® X85B 4K UHD TV  ", Description="Gelmiş geçmiş en güzel görüntü" },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Televizyon-4.jpg", Name="ev-elektronigi-Televizyon-4.jpg",Title="  BRAVIA® X85B 4K UHD TV  ", Description="Gelmiş geçmiş en güzel görüntü" },

                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Ses-Sistemleri-1.jpg", Name="ev-elektronigi-Ses-Sistemleri-1.jpg",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },
                        new SliderItem (){ FilePath= "~/content/images/slider/ev-elektronigi-Ses-Sistemleri-2.jpg", Name="ev-elektronigi-Ses-Sistemleri-2.jpg",Title="Olağanüstü etkileyicilik için kavisli 4K UHD TV ", Description="4K ayrıntılar, hassas kavisli ekran ve surround sesi bir araya getiren bu 4K UHD kavisli TV, TV izleme deneyiminizi değiştirecek." },
                    }
                }},
                { "PublicPhonePage",new Slider(){ Items=new List<SliderItem>()
                    { 
                        new SliderItem (){ FilePath= "~/content/images/slider/Telefon-1.jpeg", Name="Telefon-1.jpeg",Title="4K çözünürlüklü görüntü",Description="4K Ultra HD TV'lerimiz en iyi eğlence deneyimi için inanılmaz ayrıntılar, etkileyici netlik, gerçekçi renkler ve akıllı bağlantı özellikleri sunar." },
                        new SliderItem (){ FilePath= "~/content/images/slider/Telefon-2.jpeg", Name="Telefon-2.jpeg",Title="Olağanüstü etkileyicilik için kavisli 4K UHD TV ", Description="4K ayrıntılar, hassas kavisli ekran ve surround sesi bir araya getiren bu 4K UHD kavisli TV, TV izleme deneyiminizi değiştirecek." },
                        new SliderItem (){ FilePath= "~/content/images/slider/Telefon-3.jpeg", Name="Telefon-3.jpeg",Title="  BRAVIA® X85B 4K UHD TV  ", Description="Gelmiş geçmiş en güzel görüntü" },
                    }
                }},
            }
        };

        public static void ApplicationStart()
        {
            try
            {
                SqlSettings.CurrentDialect = SqlDialect.MsSql2005;

                Serenity.Web.CommonInitialization.Run();

                var registrar = Dependency.Resolve<IDependencyRegistrar>();
                registrar.RegisterInstance<IAuthorizationService>(new Administration.AuthorizationService());
                registrar.RegisterInstance<IAuthenticationService>(new Administration.AuthenticationService());
                registrar.RegisterInstance<IPermissionService>(new Administration.PermissionService());
                registrar.RegisterInstance<IUserRetrieveService>(new Administration.UserRetrieveService());
            }
            catch (Exception ex)
            {
                ex.Log();
                throw;
            }

            EnsureDatabase();
        }

        public static void ApplicationEnd()
        {
            Log.Dispose();
        }

        private static void EnsureDatabase()
        {
            using (var connection = SqlConnections.NewByKey("Default"))
                try
                {
                    connection.Open();
                }
                catch
                {
                    var cb = new DbConnectionStringBuilder();
                    cb.ConnectionString = SqlConnections.GetConnectionString("Default").ConnectionString;
                    var catalog = cb["Initial Catalog"];
                    cb["Initial Catalog"] = null;
                    cb["AttachDBFilename"] = null;

                    using (var serverConnection = new SqlConnection(cb.ConnectionString))
                    {
                        serverConnection.Open();
                        serverConnection.Execute(String.Format(
                            @"CREATE DATABASE [{0}] ON PRIMARY (Name = N'{0}', FILENAME = '{1}\{0}.mdf') LOG ON (NAME = N'{0}_log', FILENAME = '{1}\{0}.ldf');",
                                catalog, HostingEnvironment.MapPath("~/App_Data")));
                    }

                    SqlConnection.ClearAllPools();
                }

            RunMigrations();
        }

        private static void RunMigrations()
        {
            var defaultConnection = SqlConnections.GetConnectionString("Default");

            // safety check to ensure that we are not modifying another database
            if (defaultConnection.ConnectionString.IndexOf(typeof(SiteInitialization).Namespace + @"_Default_v1") < 0)
                return;

            using (var sw = new StringWriter())
            {
                var announcer = new TextWriterWithGoAnnouncer(sw)
                {
                    ShowSql = true
                };

                var runner = new RunnerContext(announcer)
                {
                    Database = "SqlServer",
                    Connection = defaultConnection.ConnectionString,
                    Target = typeof(SiteInitialization).Assembly.Location,
                    Task = "migrate:up",
                    WorkingDirectory = Path.GetDirectoryName(typeof(SiteInitialization).Assembly.Location),
                    Namespace = "Cengaver.Migrations.DefaultDB"
                };

                new TaskExecutor(runner).Execute();
            }
        }
    }

    public class SiteSetting
    {
        public string ThemeName;
        public Dictionary<string, Slider> SliderByPageName;
    }

    public class SliderItem
    {
        public string Name;
        public string Title;
        public string Description;
        public string FilePath;
        public string Tag;
    }

    public class Slider
    {
        public List<SliderItem> Items;
    }
}