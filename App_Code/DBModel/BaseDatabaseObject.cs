using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BaseDatabaseObject
/// </summary>
public class BaseDatabaseObject
{
  private string name;
	public BaseDatabaseObject()
	{

	}

  public string Name
  {
    [DebuggerStepThrough]
    get { return name; }
    [DebuggerStepThrough]
    set { name = value; }
  }
}