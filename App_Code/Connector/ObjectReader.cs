using System.Collections.Generic;
using System.Data;

namespace App_Code.Connector
{
  /// <summary>
  /// Summary description for ObjectReader
  /// </summary>
  public class ObjectReader
  {
    Connection connection;
    public ObjectReader(ConnectionOptions options)
    {
      connection = new Connection(options);
    }

    public List<string> GetDatabaseList ()
    {
      List<string> ret = new List<string>();
      DataTable dataTable = connection.ExecuteQuery(Queries.GetQuery(Objects.Database));
      if (dataTable != null)
      {
        foreach (DataRow row in dataTable.Rows)
          ret.Add((string)row[0]);
      }
      return ret;
    }

    public List<string> GetTableList (string databaseName)
    {
      List<string> ret = new List<string>();
      DataTable dataTable = connection.ExecuteQuery(Queries.GetQuery(Objects.Table, new object[] {databaseName}));
      if (dataTable != null)
      {
        foreach (DataRow row in dataTable.Rows)
          ret.Add((string)row[0]);
      }
      return ret;
    }
  }
}