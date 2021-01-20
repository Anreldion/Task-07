using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Class for working with files and folders.
    /// </summary>
    public class FileWorker
    {
        /// <summary>
        /// Create folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (IOException ex)
                {
                    throw ex;
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw ex;
                }
            }
            return true;
        }

        /// <summary>
        /// Name of folders with reports.
        /// </summary>
        public enum ReportsFolders
        {
            DeductibleStudent,
            SessionResult,
            PointsByGroup
        }

        /// <summary>
        /// Open an object at the specified path. 
        /// </summary>
        /// <param name="path"></param>
        public static void Open(string path)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", "/open, " + path));
        }
        /// <summary>
        /// Delete file if exists.
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFileIfExists(string path)
        {
            if (File.Exists(path))//Удаляем
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Delete folder if exists
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFolderIfExists(string path)
        {
            if (Directory.Exists(path))//Удаляем
            {
                try
                {
                    Directory.Delete(path);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
