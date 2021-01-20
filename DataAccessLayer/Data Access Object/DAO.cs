using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DataAccessLayer.Data_Access_Object
{
    /// <summary>
    /// CRUD functionality.
    /// </summary>
    /// <typeparam name="T">ORM</typeparam>
    public abstract class DAO<T>
    {
        /// <summary>
        /// Class constructor <see cref="DAO{T}"/>
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        protected DAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Database connection string
        /// </summary>
        private readonly string connectionString;

        /// <summary>
        /// Checking an object for existence.
        /// </summary>
        /// <param name="data">Data object</param>
        /// <returns>true if exist, otherwise false</returns>
        public async Task<bool> IsExistAsync(T data)
        {
            List<string> columns = new List<string>();
            try
            {
                using (SqlConnection Connect = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlcommand = new SqlCommand())
                    {
                        PropertyInfo[] properties = data.GetType().GetProperties();
                        foreach (var item in properties)
                        {
                            if (item.Name == "Id")
                            {
                                continue;
                            }
                            columns.Add(item.Name);
                            sqlcommand.Parameters.AddWithValue($"@{item.Name}", item.GetValue(data));
                        }

                        string parameter_str = "";
                        foreach (string column in columns)
                        {
                            if (parameter_str != "")
                            {
                                parameter_str += " and ";
                            }
                            parameter_str += $"{column}=@{column}";
                        }
                        sqlcommand.CommandText = $"SELECT * FROM [dbo].[{typeof(T).Name}s] WHERE EXISTS (SELECT * FROM [dbo].[{typeof(T).Name}s] WHERE {parameter_str})";
                        sqlcommand.Connection = Connect;
                        await Connect.OpenAsync().ConfigureAwait(false);
                        if (sqlcommand.ExecuteScalar() != null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Add data to database table.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>true if successful, otherwise false</returns>
        public async Task<bool> InsertAsync(T data)
        {
            List<string> columns = new List<string>();
            List<string> parameters = new List<string>();

            try
            {
                using (SqlConnection Connect = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        PropertyInfo[] properties = data.GetType().GetProperties();
                        foreach (var item in properties)
                        {
                            if (item.Name == "Id")
                            {
                                continue;
                            }

                            columns.Add(item.Name);
                            parameters.Add($"@{item.Name}");
                            sqlCommand.Parameters.AddWithValue(parameters.Last(), item.GetValue(data));
                        }
                        await Connect.OpenAsync().ConfigureAwait(false);
                        sqlCommand.CommandText = $"INSERT INTO [dbo].[{typeof(T).Name}s] ({string.Join(",", columns)}) VALUES ({string.Join(",", parameters)})";
                        sqlCommand.Connection = Connect;
                        await sqlCommand.ExecuteNonQueryAsync().ConfigureAwait(false);
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Get data from a table by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Data(T)</returns>
        public async Task<T> ReadAsync(int id)
        {
            try
            {
                using (SqlConnection Connect = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlcommand = new SqlCommand($"SELECT * FROM [dbo].[{typeof(T).Name}s] WHERE ID=@Id", Connect))
                    {
                        sqlcommand.Parameters.AddWithValue("@Id", id);

                        await Connect.OpenAsync().ConfigureAwait(false);

                        using (SqlDataReader Reader = sqlcommand.ExecuteReader())
                        {
                            if (Reader.HasRows && Reader.FieldCount > 0)
                            {
                                List<object> properties = new List<object>();

                                while (await Reader.ReadAsync().ConfigureAwait(false))
                                {
                                    for (int i = 0; i < Reader.FieldCount; i++)
                                    {
                                        properties.Add(Reader.GetValue(i));
                                    }
                                }
                                return (T)Activator.CreateInstance(typeof(T), properties.ToArray());
                            }
                        }
                    }
                }
                return default;
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        /// Get all data from a table.
        /// </summary>
        /// <returns><IEnumerable<T>></returns>
        public async Task<IEnumerable<T>> ReadAllAsync()
        {
            try
            {
                using (SqlConnection Connect = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlcommand = new SqlCommand($"SELECT * FROM [dbo].[{typeof(T).Name}s]", Connect))
                    {
                        await Connect.OpenAsync().ConfigureAwait(false);
                        using (SqlDataReader dataReader = await sqlcommand.ExecuteReaderAsync())
                        {
                            List<T> list = new List<T>();
                            if (dataReader.HasRows && dataReader.FieldCount > 0)
                            {
                                List<object> properties = new List<object>();
                                while (await dataReader.ReadAsync().ConfigureAwait(false))
                                {
                                    for (int i = 0; i < dataReader.FieldCount; i++)
                                    {
                                        properties.Add(dataReader.GetValue(i));
                                    }
                                    list.Add((T)Activator.CreateInstance(typeof(T), properties.ToArray()));
                                    properties.Clear();
                                }
                                return list;
                            }
                        }
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Update a record in a database table
        /// </summary>
        /// <param name="data"></param>
        /// <returns>true if successful, otherwise false</returns>
        public async Task<bool> UpdateAsync(T data)
        {
            List<string> columns = new List<string>();
            try
            {               
                using (SqlConnection Connect = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlcommand = new SqlCommand())
                    {
                        sqlcommand.Parameters.AddWithValue("@Id", typeof(T).GetProperty("Id").GetValue(data));
                        PropertyInfo[] propertys = data.GetType().GetProperties();
                        foreach (var item in propertys)
                        {
                            if(item.Name == "Id")
                            {
                                continue;
                            }

                            columns.Add($"{item.Name} = @{item.Name}");
                            sqlcommand.Parameters.AddWithValue($"@{item.Name}", item.GetValue(data));
                        }

                        await Connect.OpenAsync().ConfigureAwait(false);
                        sqlcommand.Connection = Connect;
                        sqlcommand.CommandText = $"UPDATE [dbo].[{typeof(T).Name}s] SET {string.Join(",", columns)} WHERE Id=@Id";
                        await sqlcommand.ExecuteNonQueryAsync().ConfigureAwait(false);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete record from database table
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>true if successful, otherwise false</returns>
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand($"DELETE FROM [dbo].[{typeof(T).Name}s] WHERE ID=@Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        await connection.OpenAsync().ConfigureAwait(false);
                        await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
