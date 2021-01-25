using BusinessLogicLayer;
using BusinessLogicLayer.DeductibleStudent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace NUnitTestProject
{
    /// <summary>
    /// Testing method of <see cref="ToBeExpelledStudentReport"/> class
    /// </summary>
    [TestClass]
    public class DeductibleStudentsReportsTests : ConnectionInfo
    {
        /// <summary>
        /// Create <see cref="ToBeExpelledStudentReport"/> object
        /// </summary>
        private static ToBeExpelledStudentReport Report { get; } = new ToBeExpelledStudentReport(ConnectionString);

        /// <summary>
        /// Testing <see cref="ToBeExpelledStudentReport.GetReport"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="path">Path to file</param>
        [TestMethod]
        [DataRow(1, 6, @"DSReport 1.xlsx")]
        [DataRow(2, 6, @"DSReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        /// <summary>
        /// Testing <see cref="ToBeExpelledStudentReport.GetReport(int, int, System.Func{ToBeExpelledStudentUnit, object})"/ method
        /// </summary>
        /// <param name="sessionId">Session ID</param>
        /// <param name="passing_score">Passing score</param>
        /// <param name="path">Path to file</param>
        [TestMethod]
        [DataRow(1, 6, @"DSReport 3.xlsx")]
        [DataRow(2, 6, @"DSReport 4.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingBySurnameTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score, s => s.Surname), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        [DataRow(1, 6, @"DSReport 5.xlsx")]
        [DataRow(2, 6, @"DSReport 6.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingByNameTest(int sessionId, int passing_score, string path)
        {
            Excel.CreateReportFile(Report.GetReport(sessionId, passing_score, s => s.Name), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }

    }
}
