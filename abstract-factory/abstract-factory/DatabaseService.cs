using database_factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class DatabaseService
    {
        public IDatabaseFactory Factory { get; private set; }

        // Change _connectionString and _databaseType to your own database
        private string _connectionString = @"Data Source=LAPTOP-U1R4N9B7;Initial Catalog=AbstractFactoryStudentDB;Integrated Security=True;TrustServerCertificate=true";
        private string _databaseType = "SqlServer";
        // End change

        public DatabaseService()
        {
            Factory = CreateDatabaseFactory(_connectionString);
        }

        private IDatabaseFactory CreateDatabaseFactory(string _connectionString)
        {
            if (_databaseType == "SqlServer")
            {
                return new SqlServerDatabaseFactory(_connectionString);
            }
            else if (_databaseType == "Access")
            {
                return new AccessDatabaseFactory(_connectionString);
            }
            else if (_databaseType == "Sqlite")
            {
                return new SqliteDatabaseFactory(_connectionString);
            }
            else if (_databaseType == "MySql")
            {
                return new MySqlDatabaseFactory(_connectionString);
            }
            else
            {
                throw new Exception("Invalid database type");
            }
        }
    }
}
