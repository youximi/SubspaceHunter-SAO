using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System;
using System.IO;



[AddComponentMenu("SQL")]
public static partial class SQLComponent
{
    static string dbName= "Test";//文件名
    public static string dataSandBoxPath = Application.persistentDataPath + "/" + dbName;//路径名
    public static string connectString = "URI=file:" + dataSandBoxPath;//www传输下的文件名
    //建立数据库连接
    static SqliteConnection connection;
    //数据库命令
    static SqliteCommand command;
    //数据库阅读器
    static SqliteDataReader reader;

    static public SqliteDataReader ExecuteQuery(string queryString)
    {
        command = connection.CreateCommand();
        command.CommandText = queryString;
        reader = command.ExecuteReader();
        return reader;
    }
    static public List<String> GetDataBySqlQuery(string tableName, string[] fields)
    {
        //string queryString = "select " + fields[0];
        //for (int i = 1; i < fields.Length; i++)
        //{
        //    queryString += " , " + fields[i];
        //}
        //queryString += " from " + tableName;
        //return ExecuteQuery(queryString);

        List<string> list = new List<string>();
        string queryString = "SELECT * FROM " + tableName;
        reader = ExecuteQuery(queryString);
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                object obj = reader.GetValue(i);
                list.Add(obj.ToString());
            }
        }
        return list;
    }
    static string CS2DB(Type type)
    {
        string result = "Text";
        if (type == typeof(Int32))
        {
            result = "Int";
        }
        else if (type == typeof(String))
        {
            result = "Text";
        }
        else if (type == typeof(Single))
        {
            result = "FLOAT";
        }
        else if (type == typeof(Boolean))
        {
            result = "Bool";
        }
        return result;
    }
    //打开数据库
    public static void OpenConnect()
    {
        try
        {
            //数据库存放在 Asset/StreamingAssets
            string path = dbName;//就是subspaceHunter 设置为Privatel了
                                 //  Show_OnTextDebug("enter_connect");
                                 //新建数据库连接
            connection = new SqliteConnection(GetDataPath(path));
            // Show_OnTextDebug("新建链接");
            //打开数据库
            connection.Open();

            Debug.Log(dataSandBoxPath);
            // Show_OnTextDebug("打开数据库");
            Debug.Log("打开数据库");
        }
        catch (Exception ex)
        {
            // Show_OnTextDebug(ex.ToString());
            Debug.Log(ex.ToString());
        }

    }
    public static string GetDataPath(string databasePath)
    {


#if UNITY_EDITOR
        //return connectString;//模拟安卓使用，即相当于对persistent直接模拟
        return "data source=" + Application.streamingAssetsPath + "/" + databasePath;//模拟editor操作使用 即在unity editor下直接对streaming asset操作
#elif UNITY_ANDROID
               return  connectString;//"URI=file:" + Application.persistentDataPath + "/" + databasePath;
#endif

#if UNITY_IOS
               return "data source=" + Application.persistentDataPath + "/" + databasePath;
#endif
    }

    
    public static IEnumerator copyDbFile()//将StreamingAsset 拷贝到persistent path下
    {
        
        Debug.Log(dataSandBoxPath);

        if (System.IO.File.Exists(SQLComponent.dataSandBoxPath))//存在文件直接返回
        {
            yield break;

        }
        if (!Directory.Exists(Application.persistentDataPath))
        {
            Directory.CreateDirectory(Application.persistentDataPath);
        }
        WWW loadWWW = new WWW(Path.Combine(Application.streamingAssetsPath, dbName));
        // Debug.Log(Path.Combine(Application.streamingAssetsPath, dbName));
        yield return loadWWW;
        File.WriteAllBytes(dataSandBoxPath, loadWWW.bytes);
        //Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.
        
        //SQLTest.instance.p();

    }
    //关闭数据库
    public static void CloseDB()
    {
        if (command != null)
        {
            command.Cancel();
        }
        command = null;

        if (reader != null)
        {
            reader.Close();
        }
        reader = null;

        if (connection != null)
        {
            //connection.Close();
        }
        connection = null;

        Debug.Log("关闭数据库");
    }

}
