using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindConnections.Classes
{
    public class Operations
    {
        public delegate void OnTaskCompleted(Task sender);
        public static event OnTaskCompleted Completed;

        private static string _databaseFileName => "C:\\OED\\Dotnetland\\VS2019\\NorthData\\NorthWind2020.mdf";

        /// <summary>
        /// Database local connection string
        /// </summary>
        private static readonly string ConnectionString = $"Server=.\\SQLExpress;AttachDbFilename={_databaseFileName};Trusted_Connection=Yes;";

        public static void RunTask()
        {
            if (DoesDatabaseExists())
            {
                CanConnect();
                ReadCategories();
            }

        }
        /// <summary>
        /// Determine if database exists File.Exists(_databaseFileName);
        /// </summary>
        public static bool DatabaseExists()
        {
            if (Environment.UserName != "PayneK") return File.Exists(_databaseFileName);

            if (_databaseFileName.Contains("2020"))
            {
                Completed?.Invoke(new Task() { ErrorMessage = "Karen!!! change the database to 2020", Success = "Failed"});
                return false;
            }

            return File.Exists(_databaseFileName);
        }

        public static bool DoesDatabaseExists()
        {
            var caller = nameof(DoesDatabaseExists).SplitCamelCase();

            Completed?.Invoke(DatabaseExists() ? 
                new Task() { Success = "Passed", Name = caller, ErrorMessage = "N/A" } : 
                new Task() { Success = "Failed", Name = caller, ErrorMessage = $"{_databaseFileName} not found" });

            return DatabaseExists();
        }
        public static void CanConnect()
        {
            var caller = nameof(CanConnect).SplitCamelCase();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                try
                {
                    cn.Open();
                    Completed?.Invoke(new Task()
                    {
                        Success = "Passed", 
                        Name = caller, 
                        ErrorMessage = "N/A"
                    });

                }
                catch (Exception exception)
                {
                    Completed?.Invoke(new Task()
                    {
                        Success = "Failed", 
                        Name = caller, 
                        ErrorMessage = exception.Message
                    });
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        /// <summary>
        /// Simple SELECT on Categories table
        /// </summary>
        public static void ReadCategories()
        {
            var caller = nameof(ReadCategories).SplitCamelCase();


            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                try
                {
                    cn.Open();
                    using var cmd = new SqlCommand()
                    {
                        Connection = cn,
                        CommandText = "SELECT TOP 1 CategoryID, CategoryName FROM dbo.Categories;"
                    };

                    var reader = cmd.ExecuteReader();
                    reader.Read();

                    var _ = $"{reader.GetInt32(0),-3:D2}{reader.GetString(1)}";

                    Completed?.Invoke(new Task()
                    {
                        Success = "Passed", 
                        Name = caller, 
                        ErrorMessage = "N/A"
                    });

                }
                catch (Exception exception)
                {

                    Completed?.Invoke(new Task()
                    {
                        Success = "Failed",
                        Name = caller, 
                        ErrorMessage = exception.Message
                    });
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
