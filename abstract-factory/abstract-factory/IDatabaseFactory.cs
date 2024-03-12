using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public interface IDatabaseFactory
    {
        DbParameter CreateParameter(string name, object value);
        DbCommand CreateCommand();
        DbCommand CreateCommand(string cmdText);
        DbCommand CreateCommand(string cmdText, DbConnection cn);
        DbConnection CreateConnection();
        DbConnection CreateConnection(string cnString);
        DbDataAdapter CreateDataAdapter();
        DbDataAdapter CreateDataAdapter(DbCommand selectCmd);
        DbDataReader CreateDataReader(DbCommand dbCmd);
    }
}
