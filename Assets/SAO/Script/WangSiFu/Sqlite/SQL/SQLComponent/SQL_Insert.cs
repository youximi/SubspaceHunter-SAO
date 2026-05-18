using Mono.Data.Sqlite;
using UnityEngine;

public static partial class SQLComponent
{
    /// <summary>
    /// 向指定数据表中插入数据
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static SqliteDataReader InsertValues(string tableName, string[] values)
    {
        string sql = "INSERT INTO " + tableName + " values (";
        foreach (var item in values)
        {
            sql += "'" + item + "',";
        }
        sql = sql.TrimEnd(',') + ")";     
        return ExecuteQuery(sql);
    }

    /// <summary>
    /// where不可用在insert
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="columnName"></param>
    /// <param name="values"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static SqliteDataReader InsertValues_specifi(string tableName, string columnName,string[] values, string id)
    {
        string sql = "INSERT INTO " + tableName + "( "+columnName+" )" + " values (";
        foreach (var item in values)
        {
            sql += "'" + item + "',";
        }
        sql = sql.TrimEnd(',') + ")";

      //  sql += " WHERE " + "id" + " = " +id;
        Debug.Log(sql);
        return ExecuteQuery(sql);
    }

    /// <summary>
    /// 插入数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <returns></returns>
    public static SqliteDataReader Insert<T>(T t)
    {
        var type = typeof(T);
        var fields = type.GetFields();
        string sql = "INSERT INTO " + type.Name + " values (";

        foreach (var field in fields)
        {
            //通过反射得到对象的值
            sql += "'" + type.GetField(field.Name).GetValue(t) + "',";
        }
        sql = sql.TrimEnd(',') + ");";
        

        return ExecuteQuery(sql);
    }

}
