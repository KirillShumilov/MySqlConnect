using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code.Connector;

public partial class Connection : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    connectionControl.Connected += new Action<App_Code.Connector.ConnectionOptions>(connectionControl_Connected);
  }

  private void connectionControl_Connected(App_Code.Connector.ConnectionOptions obj)
  {
    Session["ConnectionOptions"] = obj;
    Response.Redirect("Working.aspx");
  }
}