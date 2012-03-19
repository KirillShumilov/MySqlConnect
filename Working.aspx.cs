using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code.Connector;

public partial class Working : System.Web.UI.Page
{

  protected void Page_Load(object sender, EventArgs e)
  {
    if (Session["ConnectionOptions"] == null)
      Response.Redirect("Connection.aspx");
  }
}