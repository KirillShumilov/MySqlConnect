using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for ObjectTreeNode
/// </summary>
public class ObjectTreeNode: TreeNode
{
	public ObjectTreeNode(): base()
	{

	}
  public ObjectTreeNode(string text, Objects objectType): base (text)
  {
    ObjectType = objectType;
  }

  public Objects ObjectType { get; set; }
}