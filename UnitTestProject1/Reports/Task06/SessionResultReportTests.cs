using BusinessLogicLayer;
using BusinessLogicLayer.SessionResult;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace NUnitTestProject
{
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
