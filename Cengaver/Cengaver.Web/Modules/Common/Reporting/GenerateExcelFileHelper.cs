using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using Serenity;
using Serenity.Data;
using Serenity.Reflection;
using Serenity.Reporting;
using Serenity.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Serenity.Web
{
    public class GenerateCsvRequest : ServiceRequest
    {
        public List<string> Captions { get; set; }
        public List<string[]> Data { get; set; }
        public string DownloadName { get; set; }
    }

    public class GenerateExcelFileRequest : ServiceRequest
    {
        public List<string> Captions { get; set; }
        public List<object[]> Data { get; set; }
        public string DownloadName { get; set; }
    }

    public static class GenerateExcelFileHelper
    {
        public static ExcelPackage Generate(GenerateExcelFileRequest request)
        {
            request.CheckNotNull();

            if (request.Captions == null)
                throw new ArgumentNullException("captions");

            if (request.Data == null)
                throw new ArgumentNullException("data");

            var package = new ExcelPackage();
            var workbook = package.Workbook;
            var worksheet = package.Workbook.Worksheets.Add("Page1");

            int endCol = request.Captions.Count;
            int endRow = request.Data.Count + 1;

            var heading = worksheet.Cells[1, 1, 1, request.Captions.Count];
            heading.LoadFromArrays(new List<object[]>() { request.Captions.ConvertAll<object>(x => x).ToArray() });

            if (request.Data.Count > 0)
            {
                var dataRange = worksheet.Cells[2, 1, endRow, endCol];
                dataRange.LoadFromArrays(request.Data);
            }

            var tableRange = worksheet.Cells[1, 1, endRow, endCol];
            var table = worksheet.Tables.Add(tableRange, "Table1");
            table.TableStyle = TableStyles.Medium2;

            for (var i = 1; i <= endCol; i++)
                worksheet.Column(i).AutoFit();

            return package;
        }

        public static ExcelPackage Generate(List<ReportColumn> columns, IList rows)
        {
            if (columns == null)
                throw new ArgumentNullException("columns");

            if (rows == null)
                throw new ArgumentNullException("rows");

            Field[] fields = null;
            TypeAccessor accessor = null;

            var package = new ExcelPackage();
            var workbook = package.Workbook;
            var worksheet = package.Workbook.Worksheets.Add("Page1");

            var colCount = columns.Count;

            int endCol = colCount;
            int endRow = rows.Count + 1;

            var heading = worksheet.Cells[1, 1, 1, columns.Count];
            heading.LoadFromArrays(new List<object[]>() { columns.ConvertAll(x => (x.Title ?? x.Name)).ToArray() });

            var dataList = new List<object[]>();
            foreach (var obj in rows)
            {
                var data = new object[colCount];
                var row = obj as Row;
                if (row != null)
                {
                    if (fields == null)
                    {
                        fields = new Field[colCount];
                        for (var i = 0; i < columns.Count; i++)
                        {
                            var n = columns[i].Name;
                            fields[i] = row.FindFieldByPropertyName(n) ?? row.FindField(n);
                        }
                    }
                }
                else if (obj != null)
                {
                    if (accessor == null)
                        accessor = TypeAccessor.Create(obj.GetType());
                }

                for (var c = 0; c < colCount; c++)
                {
                    if (row != null)
                    {
                        data[c] = fields[c].AsObject(row);
                    }
                    else if (obj != null)
                    {
                        data[c] = accessor[obj, columns[c].Name];
                    }
                }

                dataList.Add(data);
            }

            if (rows.Count > 0)
            {
                var dataRange = worksheet.Cells[2, 1, endRow, endCol];
                dataRange.LoadFromArrays(dataList);
            }

            var tableRange = worksheet.Cells[1, 1, endRow, endCol];
            var table = worksheet.Tables.Add(tableRange, "Table1");
            table.TableStyle = TableStyles.Medium2;

            for (var i = 1; i <= endCol; i++)
            {
                var column = columns[i - 1];
                if (!column.Format.IsEmptyOrNull())
                    worksheet.Column(i).Style.Numberformat.Format = column.Format;

                worksheet.Column(i).AutoFit(1, 100);
            }

            for (var colNum = 1; colNum <= endCol; colNum++)
            {
                var col = columns[colNum - 1];
                var decorator = col.Decorator;
                if (decorator != null)
                {
                    for (var rowNum = 2; rowNum <= endRow; rowNum++)
                    {
                        var obj = rows[rowNum - 2];
                        var row = obj as Row;

                        decorator.Item = obj;
                        decorator.Name = col.Name;
                        decorator.Format = null;
                        decorator.Background = Color.Empty;
                        decorator.Foreground = Color.Empty;

                        object value;
                        if (row != null)
                        {
                            value = fields[colNum - 1].AsObject(row);
                        }
                        else if (obj != null)
                        {
                            value = accessor[obj, col.Name];
                        }
                        else
                            continue;

                        decorator.Value = value;

                        decorator.Decorate();

                        if (decorator.Background != Color.Empty ||
                            decorator.Foreground != Color.Empty ||
                            !Object.Equals(decorator.Value, value) ||
                            decorator.Format != null)
                        {
                            var cell = worksheet.Cells[rowNum, colNum];

                            if (decorator.Background != Color.Empty)
                            {
                                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cell.Style.Fill.BackgroundColor.SetColor(decorator.Background);
                            }

                            if (decorator.Foreground != Color.Empty)
                                cell.Style.Font.Color.SetColor(decorator.Foreground);

                            if (decorator.Format != null)
                                cell.Style.Numberformat.Format = decorator.Format;

                            if (!Object.Equals(decorator.Value, value))
                                cell.Value = decorator.Value;
                        }
                    }
                }
            }

            return package;
        }
    }
}