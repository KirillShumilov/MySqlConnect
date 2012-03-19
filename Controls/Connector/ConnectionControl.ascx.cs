using System;
using App_Code.Connector;

namespace Controls.Connector
{
  public partial class ConnectionControl : System.Web.UI.UserControl
  {
    public event Action<ConnectionOptions> Connected;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConnect_Click(object sender, EventArgs e)
    {
      ConnectionOptions connectionOptions = new ConnectionOptions();
      connectionOptions.HostName = teHostName.Text;
      connectionOptions.Login = teLogin.Text;
      connectionOptions.Password = tePassword.Text;
      connectionOptions.Port = Convert.ToInt32(tePort.Text);
      string message;
      if (testConnection(connectionOptions, out message))
        raiseConnectedEvent(connectionOptions);
      else
        lblResult.Text = message;
    }

    private void raiseConnectedEvent(ConnectionOptions options)
    {
      if (Connected != null)
        Connected(options);
    }

    private bool testConnection(ConnectionOptions options, out string message)
    {
      message = string.Empty;
      Connection connection = new Connection(options);
      bool result = true;
      try
      {
        connection.Connect();
      }
      catch (Exception exc)
      {
        message = exc.Message;
        result = false;
      }
      finally
      {
        connection.Disconnect();
      }
      return result;
    }
  }
}