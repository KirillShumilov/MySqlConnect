using System;
using System.Web.UI.WebControls;
using App_Code.Connector;

namespace Controls.ObjectBrowser
{
  public partial class ObjectBrowser : System.Web.UI.UserControl
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        objectTree.Nodes.Clear();
        AddNode("Databases", Objects.Databases, null);
        ObjectReader objectReader = new ObjectReader((ConnectionOptions)Session["ConnectionOptions"]);

        foreach (string db in objectReader.GetDatabaseList())
          AddNode(db, Objects.Database, objectTree.Nodes[0]);
      }
    }

    protected void objectTree_TreeNodePopulate(object sender, TreeNodeEventArgs e)
    {
      ObjectTreeNode node = (ObjectTreeNode) e.Node;
      if (node.ObjectType == Objects.Database)
      {
        AddNode(Objects.Tables.ToString(), Objects.Tables, e.Node);
        AddNode(Objects.Views.ToString(), Objects.Views, e.Node);
      }
      else if (node.ObjectType == Objects.Tables)
      {
        ObjectReader objectReader = new ObjectReader((ConnectionOptions)Session["ConnectionOptions"]);
        foreach (var table in objectReader.GetTableList(e.Node.Parent.Text))
          AddNode(table, Objects.Table, e.Node, false);
      }
    }

    private void AddNode(string text, Objects type, TreeNode parent)
    {
      AddNode(text, type, parent, true);
    }

    private void AddNode(string text, Objects type, TreeNode parent, bool populateOnDemand)
    {
      ObjectTreeNode node = new ObjectTreeNode(text, type);
      node.PopulateOnDemand = populateOnDemand;
      node.SelectAction = TreeNodeSelectAction.Expand;
      node.Collapse();
      if (parent != null)
        parent.ChildNodes.Add(node);
      else
        objectTree.Nodes.Add(node);
    }


  }
}