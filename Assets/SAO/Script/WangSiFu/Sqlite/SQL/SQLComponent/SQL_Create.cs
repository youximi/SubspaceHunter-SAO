using Mono.Data.Sqlite;

public static partial class SQLComponent
{
    public static void CreateTable<T>()
    {
        var type = typeof(T);
        string sql = "create Table " + type.Name + "( ";
        var fields = type.GetFields();
        for (int i = 0; i < fields.Length; i++)
        {
            sql += " " + fields[i].Name + " " + CS2DB(fields[i].FieldType) + ",";
        }
        sql = sql.TrimEnd(',') + ")";
        ExecuteQuery(sql);
    }
    public static SqliteDataReader CreateTable(string tableName, string[] colNames, string[] colTypes)
    {
        string queryString = "create table " + tableName + "(" + colNames[0] + " " + colTypes[0];
        for (int i = 1; i < colNames.Length; i++)
        {
            queryString += ", " + colNames[i] + " " + colTypes[i];
        }
        queryString += " )";

        return ExecuteQuery(queryString);
    }
}
