using Mono.Data.Sqlite;



public static partial class SQLComponent
{
    /// <summary>
    /// 删除表
    /// </summary>
    /// <param name="tableName"></param>
    /// <returns></returns>
    public static SqliteDataReader DeleteTable(string tableName)
    {
        string sql = "DROP TABLE " + tableName;
        return ExecuteQuery(sql);
    }
    /// <summary>
    /// 删除数据
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="conditions">查询条件</param>
    /// <returns></returns>
    public static SqliteDataReader DeleteValues(string tableName, string[] conditions)
    {
        string sql = "delete from " + tableName + " where (";
        for (int i = 0; i < conditions.Length - 1; i += 2)
        {
            sql += conditions[i] + "='" + conditions[i + 1] + "' and ";
        }
        sql = sql.Substring(0, sql.Length - 4) + ");";
        return ExecuteQuery(sql);
    }
}
