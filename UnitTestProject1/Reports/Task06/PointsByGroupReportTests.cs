using BusinessLogicLayer;
using BusinessLogicLayer.PointsByGroup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace NUnitTestProject
{
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
        [TestMethod]
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
        [TestMethod]
        [DataRow(@"PBGReport 2.xlsx")]
        [Description("Testing GetReport method")]
        public void GetReportSortingTest(string path)
        {
            Excel.CreateReportFile(Report.GetReport(s => s.AverageScore), path, OpenFileAfterCreation);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
