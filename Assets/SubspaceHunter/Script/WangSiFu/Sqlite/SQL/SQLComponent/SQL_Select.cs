using Mono.Data.Sqlite;
public static partial class SQLComponent
{
    public static SqliteDataReader SelectFullTableData(string tableName)
    {
        string queryString = "select * from " + tableName;
        return ExecuteQuery(queryString);
    }
    /// <summary>
    /// 查询数据
    /// </summary>
    /// <param name="tableName">数据表名</param>
    /// <param name="values">需要查询的数据</param>
    /// <param name="fields">查询的条件</param>
    /// <returns></returns>
    public static SqliteDataReader SelectData(string tableName, string[] values, string[] fields)
    {
        string sql = "select " + values[0];
        for (int i = 1; i < values.Length; i++)
        {
            sql += " , " + values[i];
        }
        sql += " from " + tableName + " where( ";
        for (int i = 0; i < fields.Length - 1; i += 2)
        {
            sql += fields[i] + " =' " + fields[i + 1] + " 'and ";
        }
        sql = sql.Substring(0, sql.Length - 4) + ");";
        return ExecuteQuery(sql);


        //用于查看打印
        //List<string> list = new List<string>();
        //reader = ExecuteQuery(sql);

        //for (int i = 0; i < reader.FieldCount; i++)
        //{
        //    object obj = reader.GetValue(i);
        //    list.Add(obj.ToString());
        //}
        //return list;
    }

}
