using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using BusinessLogicLayer.PointsByGroup;
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
    public class ConnectionInfo
    {
        /// <summary>
        /// Database connection string
        /// </summary>
        public const string ConnectionString = @"Data Source=UserPC\SQLEXPRESS; Initial Catalog=SessionResultsDatabase; Integrated Security=true;";

        /// <summary>
        /// Open file after creation.
        /// </summary>
        public bool OpenFileAfterCreation = false;
    }
    /// <summary>
    /// Testing method of <see cref="DeductibleStudentsReport"/> class
    /// </summary>
    [TestClass]
    public class DeductibleStudentsReportsTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="DeductibleStudentsReport"/> object
        /// </summary>
        private static DeductibleStudentsReport Report { get; } = new DeductibleStudentsReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="DeductibleStudentsReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="path">Path to file</param>
        [DataRow(1, 6, @"DSReport 1.xlsx")]
        [DataRow(2, 6, @"DSReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="DeductibleStudentsReport.GetReport(int, int, System.Func{DeductibleStudentUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="path">Path to file</param>
        [DataRow(1, 6, @"DSReport 3.xlsx")]
        [DataRow(2, 6, @"DSReport 4.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingBySurnameTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score, s => s.Surname), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        [DataRow(1, 6, @"DSReport 5.xlsx")]
        [DataRow(2, 6, @"DSReport 6.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingByNameTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score, s => s.Name), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

    }

    /// <summary>
    /// Testing method of <see cref="PointsByGroupReport"/> class
    /// </summary>
    [TestClass]
    public class PointsByGroupReportTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="PointsByGroupReport"/> object
        /// </summary>
        private static PointsByGroupReport Report { get; } = new PointsByGroupReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="PointsByGroupReport.GetReport"/ method
        /// </summary>
        /// <param name="path">Path to file</param>
        [DataRow(@"PBGReport 1.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportTest(string path)
        {
            Excel.CreateReportFile(Report.GetReport(), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="PointsByGroupReport.GetReport(System.Func{PointsByGroupUnit, object})"/ method
        /// </summary>
        /// <param name="path">Path to file</param>
        [DataRow(@"PBGReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(string path)
        {
            Excel.CreateReportFile(Report.GetReport(s => s.AverageScore), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }
    }

    /// <summary>
    /// Testing method of <see cref="SessionResultReport"/> class
    /// </summary>
    [TestClass]
    public class SessionResultReportTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="SessionResultReport"/> object
        /// </summary>
        private static SessionResultReport Report { get; } = new SessionResultReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="SessionResultReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [DataRow(1, "SRReport 1.xlsx")]
        [DataRow(2, "SRReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void SessionResultReportTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="SessionResultReport.GetReport(int, System.Func{SessionResultUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="path">Path to file</param>
        [DataRow(1, @"SRReport 3.xlsx")]
        [DataRow(2, @"SRReport 4.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(int sessionId, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, s => s.Subject), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
