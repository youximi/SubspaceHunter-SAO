using Mono.Data.Sqlite;

/// <summary>
/// https://www.w3schools.com/sql/sql_alter.asp
/// </summary>


public static partial class SQLComponent
{
    public static SqliteDataReader AddColumn(string tableName, string columnName, string dataType)
    {
        string sql = "ALTER TABLE " + tableName + " ADD "+columnName+" "+dataType;
        

        return ExecuteQuery(sql);
    }

}
