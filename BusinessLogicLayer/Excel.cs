using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using BusinessLogicLayer.SessionResult;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Class for generating .xlxs reports.
    /// </summary>
    public class Excel
    {
        /// <summary>
        /// Set header style
        /// </summary>
        /// <param name="workSheet"></param>
        /// <param name="row"></param>
        private static void SetHeaderStyle(ExcelWorksheet workSheet, int row)
        {
            workSheet.Row(row).Style.WrapText = true;
            workSheet.Row(row).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            workSheet.Row(row).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            workSheet.Row(row).Height = 30;

        }

        /// <summary>
        /// Form a list of students to be expelled, grouped by group.
        /// </summary>
        /// <param name="data_table">List contains <see cref="DeductibleStudentsTable"/></param>
        /// <param name="filePath">The path to the file</param>
        public static void CreateReportFile(IEnumerable<DeductibleStudentsTable> data_table, string filePath, bool open_after_creation = false)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;


                foreach (var data in data_table)
                {
                    ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.GroupName);

                    SetHeaderStyle(workSheet, 1);

                    workSheet.Column(1).Width = 4;
                    workSheet.Column(2).Width = 14;
                    workSheet.Column(3).Width = 16;
                    workSheet.Column(4).Width = 16;
                    workSheet.Column(5).Width = 10;

                    workSheet.Cells["A1:E1"].Style.Font.Size = 10;
                    workSheet.Cells["A1:E1"].Style.Font.Name = "Arial Cyr";
                    workSheet.Cells["A1:E1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:E1"].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Medium);
                    workSheet.Cells["B1:D1"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    workSheet.Cells["B1:D1"].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                    workSheet.Cells[1, 1].Value = "№ ";
                    workSheet.Cells[1, 2].Value = "Surname";
                    workSheet.Cells[1, 3].Value = "Name";
                    workSheet.Cells[1, 4].Value = "Middlename";
                    workSheet.Cells[1, 5].Value = "Education forms";

                    var list = data.deductibleStudents.ToList();

                    int i = 2;
                    for (int j = 0; j < data.deductibleStudents.Count(); i++, j++)
                    {
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Size = 10;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Name = "Arial Cyr";
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.WrapText = true;
                        workSheet.Cells["E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;

                        workSheet.Cells[i, 1].Value = i - 1;
                        workSheet.Cells[i, 2].Value = list[j].Surname;
                        workSheet.Cells[i, 3].Value = list[j].Name;
                        workSheet.Cells[i, 4].Value = list[j].MiddleName;
                        workSheet.Cells[i, 5].Value = list[j].EducationForm;
                    }
                    workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                }

                excelPackage.Save();

                if (open_after_creation)
                {
                    FileWorker.Open(filePath);
                }
            }
        }
        /// <summary>
        /// For each session, display the xlsx pivot table with the average / minimum / maximum score for each group.
        /// </summary>
        /// <param name="data_table">List contains <see cref="PointsByGroupTable"/></param>
        /// <param name="filePath">The path to the file</param>
        public static void CreateReportFile(IEnumerable<PointsByGroupTable> data_table, string filePath, bool open_after_creation = false)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                foreach (var data in data_table)
                {
                    ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.SessionPeriod);

                    SetHeaderStyle(workSheet, 1);

                    workSheet.Column(1).Width = 4;
                    workSheet.Column(2).Width = 15;
                    workSheet.Column(3).Width = 10;
                    workSheet.Column(4).Width = 10;
                    workSheet.Column(5).Width = 10;

                    workSheet.Cells["A1:E1"].Style.Font.Size = 10;
                    workSheet.Cells["A1:E1"].Style.Font.Name = "Arial Cyr";
                    workSheet.Cells["A1:E1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:E1"].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Medium);
                    workSheet.Cells["B1:D1"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    workSheet.Cells["B1:D1"].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                    workSheet.Cells[1, 1].Value = "№ ";
                    workSheet.Cells[1, 2].Value = "Group Name";
                    workSheet.Cells[1, 3].Value = "Minimum Score";
                    workSheet.Cells[1, 4].Value = "Average Score";
                    workSheet.Cells[1, 5].Value = "Maximum Score";

                    var list = data.pointsByGroups.ToList();

                    int i = 2;
                    for (int j = 0; j < data.pointsByGroups.Count(); i++, j++)
                    {
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Size = 10;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Font.Name = "Arial Cyr";
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.WrapText = true;
                        workSheet.Cells["E" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        workSheet.Row(i).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        workSheet.Row(i).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                        

                        workSheet.Cells[i, 1].Value = i - 1;
                        workSheet.Cells[i, 2].Value = list[j].GroupName;
                        workSheet.Cells[i, 3].Value = list[j].MinimumScore;
                        workSheet.Cells[i, 4].Value = list[j].AverageScore;
                        workSheet.Cells[i, 5].Value = list[j].MaximumScore;
                    }
                    workSheet.Cells["A" + i.ToString() + ":E" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                }
                excelPackage.Save();

                if (open_after_creation)
                {
                    FileWorker.Open(filePath);
                }
               
            }
        }

        /// <summary>
        /// Saving in xlsx format file of session results for each group in the form of a table.
        /// </summary>
        /// <param name="data_table">List contains <see cref="SessionResultTable"/></param>
        /// <param name="filePath">The path to the file</param>
        public static void CreateReportFile(IEnumerable<SessionResultTable> data_table, string filePath, bool open_after_creation = false)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                foreach (var data in data_table)
                {
                    ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.GroupName);
                    SetHeaderStyle(workSheet, 1);
                    workSheet.Column(1).Width = 4;
                    workSheet.Column(2).Width = 30;
                    workSheet.Column(3).Width = 25;
                    workSheet.Column(4).Width = 10;
                    workSheet.Column(5).Width = 12;
                    workSheet.Column(6).Width = 10;

                    workSheet.Cells["A1:F1"].Style.Font.Size = 10;
                    workSheet.Cells["A1:F1"].Style.Font.Name = "Arial Cyr";
                    workSheet.Cells["A1:F1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:F1"].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Medium);
                    workSheet.Cells["B1:E1"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    workSheet.Cells["B1:E1"].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                    workSheet.Cells[1, 1].Value = "№ ";
                    workSheet.Cells[1, 2].Value = "Student";
                    workSheet.Cells[1, 3].Value = "Subject";
                    workSheet.Cells[1, 4].Value = "Mark";
                    workSheet.Cells[1, 5].Value = "Date";
                    workSheet.Cells[1, 6].Value = "Test form";

                    var list = data.sessionResults.ToList();
                    int i = 2;
                    for (int j = 0; j < data.sessionResults.Count(); i++, j++)
                    {
                        workSheet.Cells["A" + i.ToString() + ":F" + i.ToString()].Style.Font.Size = 10;
                        workSheet.Cells["A" + i.ToString() + ":F" + i.ToString()].Style.Font.Name = "Arial Cyr";
                        workSheet.Cells["A" + i.ToString() + ":F" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":F" + i.ToString()].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":F" + i.ToString()].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        workSheet.Cells["A" + i.ToString() + ":F" + i.ToString()].Style.WrapText = true;
                        workSheet.Cells["F" + i.ToString()].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        workSheet.Row(i).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        workSheet.Row(i).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                        workSheet.Cells[i, 1].Value = i - 1;
                        workSheet.Cells[i, 2].Value = $"{list[j].Surname} {list[j].Name} {list[j].MiddleName}";
                        workSheet.Cells[i, 3].Value = list[j].Subject;
                        workSheet.Cells[i, 4].Value = list[j].Mark;
                        workSheet.Cells[i, 5].Value = list[j].Date.ToString("dd.MM.yyyy");
                        workSheet.Cells[i, 6].Value = list[j].TestForm;
                    }
                    workSheet.Cells["A" + i.ToString() + ":F" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                }
                excelPackage.Save();

                if (open_after_creation)
                {
                    FileWorker.Open(filePath);
                }
            }
        }
    }
}
