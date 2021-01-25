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
}
