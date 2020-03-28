using OfficeOpenXml;
using System;
using System.IO;

namespace ЦДО.Forms
{
    class GenerateDox
    {
        public bool GenerateDoxOnes(string fileName, string[] data)
        {
            try
            {
                string rootFolder = @"C:\Users\Yulia\Desktop\VeloAPI\resours\Export\"; //Путь                 

                FileInfo file = new FileInfo(rootFolder + fileName);

                using (ExcelPackage package = new ExcelPackage(file))
                {
                    package.Workbook.Properties.Author = "VeloNSKAPI"; //Автор
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Пользователи"); //Необязательно
                    worksheet.Cells[1, 1].Value = "Участники";
                    worksheet.Cells[1, 1].Style.Font.Size = 14;
                    worksheet.Cells[1, 1].Style.Font.Bold = true;
                    worksheet.Cells["A1:I1"].Merge = true;

                    //int totalRows = customerList.Count();

                    worksheet.Cells[2, 1].Value = "Login";
                    worksheet.Cells[2, 2].Value = "Роль";
                    worksheet.Cells[2, 3].Value = "Фамилия";
                    worksheet.Cells[2, 4].Value = "E-mail";
                    worksheet.Cells[2, 5].Value = "Имя";
                    worksheet.Cells[2, 6].Value = "Отчество";
                    worksheet.Cells[2, 7].Value = "Возраст";
                    worksheet.Cells[2, 8].Value = "Пол";
                    worksheet.Cells[2, 9].Value = "Статус здоровья";

                    int i = 0;
                    for (int row = 3; row <= data.Length + 2; row++)
                    {
                        worksheet.Cells[row, i+1].Value = data[i];
                        i++;
                    }
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    package.Save();
                    return true;
                }
            }
            catch { return false; }
        }
    }
}
