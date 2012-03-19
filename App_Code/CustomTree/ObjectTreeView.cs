using System.Web;
using System.Web.UI.WebControls;

namespace App_Code.CustomTree
{
  /// <summary>
  /// Summary description for ObjectTree
  /// </summary>
  public class ObjectTreeView : TreeView
  {
    public ObjectTreeView()
    {
      this.EnableClientScript = false;
      this.EnableViewState = false;
      ObjectTreeView treeState = (ObjectTreeView)HttpContext.Current.Session["ObjectTreeView"];
      if (treeState != null)
      {
        for (int i = 0; i < treeState.Nodes.Count; i++)
        {
          this.Nodes.Add(treeState.Nodes[i]);
        }
      }
      else
        this.Nodes.Add(new TreeNode());
    }

    public override void Dispose()
    {
      HttpContext.Current.Session.Add("ObjectTreeView", this);
      base.Dispose();
    }
  }
}
