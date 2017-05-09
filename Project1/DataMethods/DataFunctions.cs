using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Data;

namespace Project1.DataMethods
{
    class DataFunctions
    {
        protected Func<List<string>, string, string, string, List<string>> Create_Excel_File = (datalist, PathToSave, Subject, sheetname) =>
        {
            string FullPath = PathToSave + Subject;
            XLWorkbook workbook;

            if (!File.Exists(FullPath))
                workbook = new XLWorkbook();
            else
                workbook = new XLWorkbook(FullPath);

            
            workbook.AddWorksheet(sheetname);
            var ws = workbook.Worksheet(sheetname);

            int row = 1;
            foreach (object item in datalist)
            {
                ws.Cell("A" + row.ToString()).Value = item.ToString();
                row++;
            }

            workbook.SaveAs(FullPath);
            return datalist;
        };

        public List<string> Read_From_Excel(string filepath)
        {
            XLWorkbook workbook = new XLWorkbook(filepath);
            var ws = workbook.Worksheet(1);

            List<string> datalist = new List<string>();
            int i = 1;
            foreach (IXLRow row in ws.Rows())
            {
                string value = ws.Cell(i, "A").GetValue<string>();
                datalist.Add(value);
                i++;
            }
            return datalist;
        }
    }
}
