using System;
using System.Web.UI.WebControls;
using App_Code;
using App_Code.Connector;

namespace Controls.ObjectBrowser
{
  public partial class ObjectBrowser : System.Web.UI.UserControl
  {
    private ObjectReader objectReader;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void FillControl(ConnectionOptions connectionOptions)
    {
      objectTree.Nodes.Clear();
      objectReader = new ObjectReader((ConnectionOptions)Session["ConnectionOptions"]);

      foreach(string db in objectReader.GetDatabaseList())
        AddNode(db, Objects.Database.ToString(), null);

      objectTree.TreeNodePopulate += objectTree_TreeNodePopulate;
    }

    private void objectTree_TreeNodePopulate(object sender, TreeNodeEventArgs e)
    {
      if (e.Node.Value.CompareTo(Objects.Database.ToString()) == 0)
      {
        e.Node.ChildNodes.Clear();
        AddNode(Objects.Tables.ToString(), Objects.Tables.ToString(), e.Node);
        AddNode(Objects.Views.ToString(), Objects.Views.ToString(), e.Node);
      }
      else if (e.Node.Value.CompareTo(Objects.Tables.ToString()) == 0)
      {
        e.Node.ChildNodes.Clear();
        foreach (var table in objectReader.GetTableList(e.Node.Parent.Value))
          AddNode(table, Objects.Tables.ToString(), e.Node);
      }
    }

    private void AddNode(string text, string value, TreeNode parent)
    {
      TreeNode node = new TreeNode(text, value);
      node.PopulateOnDemand = true;
      node.Expanded = false;
      if (parent != null)
        parent.ChildNodes.Add(node);
      else
        objectTree.Nodes.Add(node);
    }


  }
}