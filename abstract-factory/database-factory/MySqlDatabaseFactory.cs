using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_factory
{
    public class MySqlDatabaseFactory : IDatabaseFactory
    {
        private string _connectionString;

        public MySqlDatabaseFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbParameter CreateParameter(string name, object value)
        {
            return new MySqlParameter(name, value);
        }

        public DbCommand CreateCommand()
        {
            return new MySqlCommand();
        }

        public DbCommand CreateCommand(string cmdText)
        {
            return new MySqlCommand(cmdText);
        }

        public DbCommand CreateCommand(string cmdText, DbConnection cn)
        {
            return new MySqlCommand(cmdText, (MySqlConnection)cn);
        }

        public DbConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public DbConnection CreateConnection(string cnString)
        {
            return new MySqlConnection(cnString);
        }

        public DbDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }

        public DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new MySqlDataAdapter((MySqlCommand)selectCmd);
        }

        public DbDataReader CreateDataReader(DbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }
    }
}
