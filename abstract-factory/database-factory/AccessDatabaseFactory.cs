using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_factory
{
    public class AccessDatabaseFactory : IDatabaseFactory
    {
        private string _connectionString;

        public AccessDatabaseFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbParameter CreateParameter(string name, object value)
        {
            return new OleDbParameter(name, value);
        }

        public DbCommand CreateCommand()
        {
            return new OleDbCommand();
        }

        public DbCommand CreateCommand(string cmdText)
        {
            return new OleDbCommand(cmdText);
        }

        public DbCommand CreateCommand(string cmdText, DbConnection cn)
        {
            return new OleDbCommand(cmdText, (OleDbConnection)cn);
        }

        public DbConnection CreateConnection()
        {
            return new OleDbConnection(_connectionString);
        }

        public DbConnection CreateConnection(string cnString)
        {
            return new OleDbConnection(cnString);
        }

        public DbDataAdapter CreateDataAdapter()
        {
            return new OleDbDataAdapter();
        }

        public DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new OleDbDataAdapter((OleDbCommand)selectCmd);
        }

        public DbDataReader CreateDataReader(DbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }
    }
}
