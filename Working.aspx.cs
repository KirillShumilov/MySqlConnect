using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code.Connector;

public partial class Working : System.Web.UI.Page
{
  private ConnectionOptions connectionOptions;
  bool filled = false;
  protected void Page_Load(object sender, EventArgs e)
  {
    if (Session["ConnectionOptions"] != null)
    {
      if (!filled || !ReferenceEquals(connectionOptions,Session["ConnectionOptions"]))
      {
        connectionOptions = (ConnectionOptions) Session["ConnectionOptions"];
        fillPage();
      }
    }
    else 
      Response.Redirect("Connection.aspx");
  }

  private void fillPage()
  {
    objectBrowser.FillControl((ConnectionOptions)Session["ConnectionOptions"]);
    filled = true;
  }
}