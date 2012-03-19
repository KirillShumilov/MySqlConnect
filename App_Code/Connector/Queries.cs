namespace App_Code.Connector
{
  /// <summary>
  /// Summary description for Queries
  /// </summary>
  public static class Queries
  {
    public static string GetQuery(Objects objectType)
    {
      return GetQuery(objectType, null);
    }

    public static string GetQuery(Objects objectType, object[] parameters)
    {
      switch (objectType)
      {
        case Objects.Database:
          return "SHOW DATABASES";
        case Objects.Table:
          return string.Format("SHOW TABLES FROM {0}", parameters[0]);
      }

      return string.Empty;
    }
  }
}