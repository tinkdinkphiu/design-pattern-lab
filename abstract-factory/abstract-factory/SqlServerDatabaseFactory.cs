using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace abstract_factory
{
    public class SqlServerDatabaseFactory : IDatabaseFactory
    {
        private string _connectionString;

        public SqlServerDatabaseFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbParameter CreateParameter(string name, object value)
        {
            return new SqlParameter(name, value);
        }

        public DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public DbCommand CreateCommand(string cmdText)
        {
            return new SqlCommand(cmdText);
        }

        public DbCommand CreateCommand(string cmdText, DbConnection cn)
        {
            return new SqlCommand(cmdText, (SqlConnection)cn);
        }

        public DbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public DbConnection CreateConnection(string cnString)
        {
            return new SqlConnection(cnString);
        }

        public DbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        public DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new SqlDataAdapter((SqlCommand)selectCmd);
        }

        public DbDataReader CreateDataReader(DbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }
    }
}
