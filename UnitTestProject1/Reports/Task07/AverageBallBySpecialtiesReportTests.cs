using BLL.Task_07_Reports.AverageBallBySpecialties;
using BusinessLogicLayer;
using BusinessLogicLayer.SessionResult;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace NUnitTestProject
{
    /// <summary>
    /// Testing method of <see cref="AverageBallBySpecialtiesReport"/> class
    /// </summary>
    [TestClass]
    public class AverageBallBySpecialtiesReportTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="AverageBallBySpecialtiesReport"/> object
        /// </summary>
        private static AverageBallBySpecialtiesReport Report { get; } = new AverageBallBySpecialtiesReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="SessionResultReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [TestMethod]
        [DataRow(1, "ABBSReport 1.xlsx")]
        [DataRow(2, "ABBSReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="AverageBallBySpecialtiesReport.GetReport(int, Func{AverageBallBySpecialtiesUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [TestMethod]
        [DataRow(1, @"ABBSReport 3.xlsx")]
        [DataRow(2, @"ABBSReport 4.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, s => s.Specialty), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
