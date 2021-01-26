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
    /// Class for creation of .xlxs reports.
    /// </summary>
    public class Excel
    {
        /// <summary>
        /// Set header style.
        /// </summary>
        /// <param name="workSheet">Excel worksheet</param>
        /// <param name="row">Row</param>
        private static void SetHeaderStyle(ExcelWorksheet workSheet, int row)
        {
            workSheet.Row(row).Style.WrapText = true;
            workSheet.Row(row).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            workSheet.Row(row).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            workSheet.Row(row).Height = 30;
        }
        /// <summary>
        /// Set column names.
        /// </summary>
        /// <param name="workSheet">Excel worksheet</param>
        /// <param name="FromCol">From column</param>
        /// <param name="FromRow">From row</param>
        /// <param name="names">names</param>
        private static void SetColumnNames(ExcelWorksheet workSheet, int FromCol, int FromRow, params string[] names)
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
        /// <summary>
        /// Set column width.
        /// </summary>
        /// <param name="workSheet">Excel worksheet</param>
        /// <param name="FromCol">From column</param>
        /// <param name="width">Width</param>
        private static void SetColumnWidth(ExcelWorksheet workSheet, int FromCol, params double[] width)
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
        /// <summary>
        /// Set sheet style.
        /// </summary>
        /// <param name="workSheet">Excel worksheet</param>
        /// <param name="FromCol">From column</param>
        /// <param name="FromRow">From row</param>
        /// <param name="ToCol">To column</param>
        /// <param name="ToRow">To row</param>
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
        /// <summary>
        /// Set row style
        /// </summary>
        /// <param name="workSheet">Excel worksheet</param>
        /// <param name="FromCol">From column</param>
        /// <param name="FromRow">From row</param>
        /// <param name="ToCol">To column</param>
        /// <param name="ToRow">To row</param>
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
        /// Form a list of students to be expelled, formed by group.
        /// </summary>
        /// <param name="data_table">List contains <see cref="ToBeExpelledStudentTable"/></param>
        /// <param name="filePath">The path to the file</param>
        /// <param name="open_after_creation">Open file after creation</param>
        public static void CreateReportFile(IEnumerable<ToBeExpelledStudentTable> data_table, string filePath, bool open_after_creation = false)
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
                    SetColumnWidth(workSheet, 1, 4, 14, 16, 16, 10);
                    SetSheetStyle(workSheet, 1, 1, 5, 1);
                    SetColumnNames(workSheet, 1, 1, "№", "Surname", "Name", "Middlename", "Education forms");
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
        /// For each session, display the xlsx joint table with the average / minimum / maximum score for each group.
        /// </summary>
        /// <param name="data_table">List contains <see cref="PointsByGroupTable"/></param>
        /// <param name="filePath">The path to the file</param>
        /// <param name="open_after_creation">Open file after creation</param>
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
                    SetColumnWidth(workSheet, 1, 4, 15, 10, 10, 10);
                    SetSheetStyle(workSheet, 1, 1, 5, 1);
                    SetColumnNames(workSheet, 1, 1, "№", "Group Name", "Minimum Score", "Average Score", "Maximum Score");

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
        /// Saving in xlsx format session results for each group in table form.
        /// </summary>
        /// <param name="data_table">List contains <see cref="SessionResultTable"/></param>
        /// <param name="filePath">The path to the file</param>
        /// <param name="open_after_creation">Open file after creation</param>
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
                    SetColumnWidth(workSheet, 1, 4, 30, 25, 10, 12, 10);
                    SetSheetStyle(workSheet, 1, 1, 6, 1);
                    SetColumnNames(workSheet, 1, 1, "№", "Student", "Subject", "Mark", "Date", "Test form");

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
        /// Get information about the average score by each examiner in one session.
        /// </summary>
        /// <param name="data"><see cref="AverageBallforExaminersTable"/> object</param>
        /// <param name="filePath">The path to the file</param>
        /// <param name="open_after_creation">Open file after creation</param>
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
                SetColumnWidth(workSheet, 1, 4, 30, 10);
                SetSheetStyle(workSheet, 1, 1, 3, 1);
                SetColumnNames(workSheet, 1, 1, "№", "Examiner", "Average ball");

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
        /// Get the dynamics of changes in the average score for each subject over the years within all sessions.
        /// </summary>
        /// <param name="data_table">List contains <see cref="DynamicsOfChangeInTheAverageScoreTable"/></param>
        /// <param name="filePath">The path to the file</param>
        /// <param name="open_after_creation">Open file after creation</param>
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
                    SetColumnWidth(workSheet, 1, 4, 35, 10);
                    SetSheetStyle(workSheet, 1, 1, 3, 1);
                    SetColumnNames(workSheet,1,1, "№", "Session Period", "Average ball");

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
        /// Get information about the average score for each specialty in one session.
        /// </summary>
        /// <param name="data"><see cref="AverageBallBySpecialtiesTable"/> object</param>
        /// <param name="filePath">The path to the file</param>
        /// <param name="open_after_creation">Open file after creation</param>
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
                SetColumnWidth(workSheet, 1, 4, 30, 10);
                SetSheetStyle(workSheet, 1, 1, 3, 1);
                SetColumnNames(workSheet, 1, 1, "№", "Specialty", "Average ball");

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
