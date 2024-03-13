using System;
using System.Collections.Generic;
using System.Data.Common;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_factory
{
    public class SqliteDatabaseFactory : IDatabaseFactory
    {
        private string _connectionString;

        public SqliteDatabaseFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbParameter CreateParameter(string name, object value)
        {
            return new SqliteParameter(name, value);
        }

        public DbCommand CreateCommand()
        {
            return new SqliteCommand();
        }

        public DbCommand CreateCommand(string cmdText)
        {
            return new SqliteCommand(cmdText);
        }

        public DbCommand CreateCommand(string cmdText, DbConnection cn)
        {
            return new SqliteCommand(cmdText, (SqliteConnection)cn);
        }

        public DbConnection CreateConnection()
        {
            return new SqliteConnection(_connectionString);
        }

        public DbConnection CreateConnection(string cnString)
        {
            return new SqliteConnection(cnString);
        }

        public DbDataAdapter CreateDataAdapter()
        {
            return new SqliteDataAdapter();
        }

        public DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new SqliteDataAdapter((SqliteCommand)selectCmd);
        }

        public DbDataReader CreateDataReader(DbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }
    }
}
