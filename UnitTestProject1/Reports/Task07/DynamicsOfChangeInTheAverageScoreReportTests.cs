using BLL.Task_07_Reports.AverageBallforExaminers;
using BLL.Task_07_Reports.DynamicsOfChangeInTheAverageScore;
using BusinessLogicLayer;
using BusinessLogicLayer.SessionResult;
using DataAccessLayer.DataAccessObject;
using DataAccessLayer.ObjectRelationalMapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NUnitTestProject
{
    /// <summary>
    /// Testing method of <see cref="DynamicsOfChangeInTheAverageScoreReport"/> class
    /// </summary>
    [TestClass]
    public class DynamicsOfChangeInTheAverageScoreReportTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="AverageBallforExaminersReport"/> object
        /// </summary>
        private static DynamicsOfChangeInTheAverageScoreReport Report { get; } = new DynamicsOfChangeInTheAverageScoreReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="SessionResultReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [TestMethod]
        [DataRow("ABFEReport 1.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportTest(string path)
        {
            Excel.CreateReportFile(Report.GetReport(), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="AverageBallforExaminersReport.GetReport(int, Func{AverageBallforExaminersUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [TestMethod]
        [DataRow(@"ABFEReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(string path)
        {
            Excel.CreateReportFile(Report.GetReport(s => s.SessionPeriod), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
