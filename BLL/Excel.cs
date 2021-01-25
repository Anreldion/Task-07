using BLL.Task_07_Reports.AverageBallBySpecialties;
using BLL.Task_07_Reports.AverageBallforExaminers;
using BLL.Task_07_Reports.DynamicsOfChangeInTheAverageScore;
using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
using BusinessLogicLayer.SessionResult;
using OfficeOpenXml;
using System.Collections.Generic;
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

        private static void SetHeaderNames(ExcelWorksheet workSheet, int FromCol, int FromRow, params string[] names)
        {
            if (FromCol < 1)
            {
                FromCol = 1;
            }
            if (FromRow < 1)
            {
                FromRow = 1;
            }
            foreach (string name in names)
            {
                workSheet.Cells[FromCol, FromRow++].Value = name;
            }
        }

        private static void SetHeaderWidth(ExcelWorksheet workSheet, int FromCol, params double[] width)
        {
            if (FromCol < 1)
            {
                FromCol = 1;
            }
            foreach (double item in width)
            {
                workSheet.Column(FromCol++).Width = item;
            }
        }

        private static void SetSheetStyle(ExcelWorksheet workSheet, int FromCol, int FromRow, int ToCol, int ToRow)
        {
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Font.Size = 10;
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Font.Name = "Arial Cyr";
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Font.Bold = true;
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Medium);

            if (ToCol - FromCol > 0)
            {
                int toCol = ToCol - 1 > 0 ? ToCol - 1 : 1;
                workSheet.Cells[FromRow, FromCol, ToRow, toCol].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            }
        }

        private static void SetRowStyle(ExcelWorksheet workSheet, int FromCol, int FromRow, int ToCol, int ToRow)
        {
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Font.Size = 10;
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Font.Name = "Arial Cyr";
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            workSheet.Cells[FromRow, FromCol, ToRow, ToCol].Style.WrapText = true;
            workSheet.Cells[ToRow, ToCol].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
            workSheet.Row(FromRow).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            workSheet.Row(FromRow).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
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
                    SetHeaderWidth(workSheet, 1, 4, 14, 16, 16, 10);
                    SetSheetStyle(workSheet, 1, 1, 5, 1);
                    SetHeaderNames(workSheet, 1, 1, "№", "Surname", "Name", "Middlename", "Education forms");
                    var list = data.deductibleStudents.ToList();
                    int i = 2, num = 1;
                    foreach(var item in list)
                    {
                        SetRowStyle(workSheet, 1, i, 5, i);
                        workSheet.Cells[i, 1].Value = num++;
                        workSheet.Cells[i, 2].Value = item.Surname;
                        workSheet.Cells[i, 3].Value = item.Name;
                        workSheet.Cells[i, 4].Value = item.MiddleName;
                        workSheet.Cells[i, 5].Value = item.EducationForm;
                        i++;
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
                    SetHeaderWidth(workSheet, 1, 4, 15, 10, 10, 10);
                    SetSheetStyle(workSheet, 1, 1, 5, 1);
                    SetHeaderNames(workSheet, 1, 1, "№", "Group Name", "Minimum Score", "Average Score", "Maximum Score");

                    var list = data.pointsByGroups.ToList();
                    int i = 2, num = 1;
                    foreach (var item in list)
                    {
                        SetRowStyle(workSheet, 1, i, 5, i);
                        workSheet.Cells[i, 1].Value = num++;
                        workSheet.Cells[i, 2].Value = item.GroupName;
                        workSheet.Cells[i, 3].Value = item.MinimumScore;
                        workSheet.Cells[i, 4].Value = item.AverageScore;
                        workSheet.Cells[i, 5].Value = item.MaximumScore;
                        i++;
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
                    SetHeaderWidth(workSheet, 1, 4, 30, 25, 10, 12, 10);
                    SetSheetStyle(workSheet, 1, 1, 6, 1);
                    SetHeaderNames(workSheet, 1, 1, "№", "Student", "Subject", "Mark", "Date", "Test form");

                    var list = data.sessionResults.ToList();
                    int i = 2, num = 1;
                    foreach (var item in list)
                    {
                        SetRowStyle(workSheet, 1, i, 6, i);
                        workSheet.Cells[i, 1].Value = num++;
                        workSheet.Cells[i, 2].Value = $"{item.Surname} {item.Name} {item.MiddleName}";
                        workSheet.Cells[i, 3].Value = item.Subject;
                        workSheet.Cells[i, 4].Value = item.Mark;
                        workSheet.Cells[i, 5].Value = item.Date.ToString("dd.MM.yyyy");
                        workSheet.Cells[i, 6].Value = item.TestForm;
                        i++;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        /// <param name="open_after_creation"></param>
        public static void CreateReportFile(AverageBallforExaminersTable data, string filePath, bool open_after_creation = false)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;

                ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.SessionName);
                SetHeaderStyle(workSheet, 1);
                SetHeaderWidth(workSheet, 1, 4, 30, 10);
                SetSheetStyle(workSheet, 1, 1, 3, 1);
                SetHeaderNames(workSheet, 1, 1, "№", "Examiner", "Average ball");

                var list = data.table_rows.ToList();
                int i = 2, num = 1;
                foreach(var item in list)
                {
                    SetRowStyle(workSheet, 1, i, 3, i);

                    workSheet.Cells[i, 1].Value = num++;
                    workSheet.Cells[i, 2].Value = item.Examiner;
                    workSheet.Cells[i, 3].Value = item.AverageBall.ToString("f2");
                    i++;
                }
                workSheet.Cells["A" + i.ToString() + ":C" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                excelPackage.Save();
                if (open_after_creation)
                {
                    FileWorker.Open(filePath);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data_table"></param>
        /// <param name="filePath"></param>
        /// <param name="open_after_creation"></param>
        public static void CreateReportFile(IEnumerable<DynamicsOfChangeInTheAverageScoreTable> data_table, string filePath, bool open_after_creation = false)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                foreach (var data in data_table)
                {
                    ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.SubjectName);
                    SetHeaderStyle(workSheet, 1);
                    SetHeaderWidth(workSheet, 1, 4, 35, 10);
                    SetSheetStyle(workSheet, 1, 1, 3, 1);
                    SetHeaderNames(workSheet,1,1, "№", "Session Period", "Average ball");

                    var list = data.table_rows.ToList();
                    int i = 2, num = 1;
                    foreach(var item in list)
                    {
                        SetRowStyle(workSheet, 1, i, 3, i);
                        workSheet.Cells[i, 1].Value = num++;
                        workSheet.Cells[i, 2].Value = item.SessionPeriod;
                        workSheet.Cells[i, 3].Value = item.AverageBall.ToString("f2");
                        i++;
                    }
                    workSheet.Cells["A" + i.ToString() + ":C" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                }
                excelPackage.Save();

                if (open_after_creation)
                {
                    FileWorker.Open(filePath);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        /// <param name="open_after_creation"></param>
        public static void CreateReportFile(AverageBallBySpecialtiesTable data, string filePath, bool open_after_creation = false)
        {
            FileWorker.DeleteFileIfExists(filePath);
            FileInfo file = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.Add(data.SessionName);
                SetHeaderStyle(workSheet, 1);
                SetHeaderWidth(workSheet, 1, 4, 30, 10);
                SetSheetStyle(workSheet, 1, 1, 3, 1);
                SetHeaderNames(workSheet, 1, 1, "№", "Specialty", "Average ball");

                var list = data.table_rows.ToList();
                int i = 2, num = 1;
                foreach(var item in list)
                {
                    SetRowStyle(workSheet, 1, i, 3, i);
                    workSheet.Cells[i, 1].Value = num++;
                    workSheet.Cells[i, 2].Value = item.Specialty;
                    workSheet.Cells[i, 3].Value = item.AverageBall.ToString("f2");
                    i++;
                }
                workSheet.Cells["A" + i.ToString() + ":C" + i.ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                excelPackage.Save();
                if (open_after_creation)
                {
                    FileWorker.Open(filePath);
                }
            }
        }
    }
}
