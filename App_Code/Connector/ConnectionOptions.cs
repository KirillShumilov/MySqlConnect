using System.Diagnostics;

namespace App_Code.Connector
{
  /// <summary>
  /// Summary description for ConnectionOptions
  /// </summary>
  public class ConnectionOptions
  {
    private string hostName;
    private string login;
    private string password;
    private int port;
    private string databaseName;
  
    public ConnectionOptions()
    {
      hostName = string.Empty;
      login = string.Empty;
      password = string.Empty;
      port = -1;
      databaseName = string.Empty;
    }

    public string HostName
    {
      [DebuggerStepThrough]
      get { return hostName; }
      [DebuggerStepThrough]
      set { hostName = value; }
    }

    public string Login
    {
      [DebuggerStepThrough]
      get { return login; }
      [DebuggerStepThrough]
      set { login = value; }
    }

    public string Password
    {
      [DebuggerStepThrough]
      get { return password; }
      [DebuggerStepThrough]
      set { password = value; }
    }

    public int Port
    {
      [DebuggerStepThrough]
      get { return port; }
      [DebuggerStepThrough]
      set { port = value; }
    }

    public string DatabaseName
    {
      [DebuggerStepThrough]
      get { return databaseName; }
      [DebuggerStepThrough]
      set { databaseName = value; }
    }
  }
}