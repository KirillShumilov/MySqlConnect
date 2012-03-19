using System;
using System.Collections.Generic;
using System.Data;
using Devart.Data.MySql;

namespace App_Code.Connector
{
  /// <summary>
  /// Summary description for Connection
  /// </summary>
  public class Connection
  {
    private ConnectionOptions connectionOptions;
    private MySqlConnection mySqlConnection;
 
    public Connection(ConnectionOptions connectOptions)
    {
      connectionOptions = connectOptions;
    }

    public void Connect()
    {
      if (mySqlConnection != null && mySqlConnection.State != ConnectionState.Closed)
        Disconnect();

      mySqlConnection = new MySqlConnection(createConnectionString());
      mySqlConnection.Open();

    }

    public void Disconnect()
    {
      if (mySqlConnection != null && mySqlConnection.State != ConnectionState.Closed)
        mySqlConnection.Close();
    }

    private string createConnectionString()
    {
      MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder()
                                          {
                                            Host = connectionOptions.HostName,
                                            UserId = connectionOptions.Login,
                                            Password = connectionOptions.Password,
                                            Database = connectionOptions.DatabaseName,
                                            Port = connectionOptions.Port
                                          };
      return sb.ToString();
    }

    public DataTable ExecuteQuery(string query)
    {
      DataTable result = new DataTable();
      Connect();
      MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlConnection);
      adapter.Fill(result);
      return result;
    }
  }
}