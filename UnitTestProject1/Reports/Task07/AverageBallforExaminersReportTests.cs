using BLL.Task_07_Reports.AverageBallforExaminers;
using BusinessLogicLayer;
using BusinessLogicLayer.SessionResult;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace NUnitTestProject
{
    /// <summary>
    /// Testing method of <see cref="AverageBallforExaminersReport"/> class
    /// </summary>
    [TestClass]
    public class AverageBallforExaminersReportTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="AverageBallforExaminersReport"/> object
        /// </summary>
        private static AverageBallforExaminersReport Report { get; } = new AverageBallforExaminersReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="SessionResultReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [DataRow(1, "ABFEReport 1.xlsx")]
        [DataRow(2, "ABFEReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="AverageBallforExaminersReport.GetReport(int, Func{AverageBallforExaminersUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [DataRow(1, @"ABFEReport 3.xlsx")]
        [DataRow(2, @"ABFEReport 4.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, s => s.Subject), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
