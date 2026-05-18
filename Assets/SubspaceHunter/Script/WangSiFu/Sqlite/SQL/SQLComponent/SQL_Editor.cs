using UnityEngine;
using System;


public class SQL_Editor 
{
#if UNITY_EDITOR

    public delegate void SQL_ActionDelegate();
    static SQL_ActionDelegate ISQL_Action;
    //[UnityEditor.MenuItem("SQL/Connect")]

    static SQL_Editor()
    {
        //ISQL_Action += Connect;
        //ISQL_Action +=
        Debug.Log("SQL_Editor Was Created");

    }
    //static ~SQL_Editor()
    //{

    //}

    private static void Connect()
    {
        SQLComponent.OpenConnect();

    }
   // [UnityEditor.MenuItem("SQL/Close")]
    private static void Close()
    {
        SQLComponent.CloseDB();
    }
    [UnityEditor.MenuItem("SQL/Update")]//无法Build 因为不在Editor文件夹 单纯快速通过unity复原代码
    //参考https://forum.unity.com/threads/build-script-cannot-find-menuitem.535889/
    //或者放到Editor文件夹里，Editor文件夹里的所有文件都会在打包时被忽略。............
    public static void Update()
    {
        SQLComponent.OpenConnect();
        SQLComponent. UpdataData(SQL_Accesser.DatabaseName, new string[] { "isNewUser", "1" }, new string[] { "id", "12" });
        Debug.Log("数据更新");
        SQLComponent.CloseDB();
    }
    [UnityEditor.MenuItem("SQL/AddColumn")]
    public static void AddColumn()
    {
        SQLComponent.OpenConnect();
        UpdateDatabaseColumns("GlobalSoundVolume", "float", "0.6");
        UpdateDatabaseColumns("IsMute", "integer", "0");
        UpdateDatabaseColumns("BGMVolume", "float", "0.6");
        UpdateDatabaseColumns("IsMuteBGM", "int", "0");
        UpdateDatabaseColumns("Frequency", "int", "150");
        UpdateDatabaseColumns("Amplitude", "float", "0.6");
        SQLComponent.CloseDB();
    }
    public static void UpdateDatabaseColumns(string columnName,string type,string value)
    {
        try
        {
            SQLComponent.AddColumn(SQL_Accesser.DatabaseName, columnName, type);
            SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] {columnName, value }, new string[] { "id", "12" });
            // SQLComponent.AddColumn(SQL_Accesser.DatabaseName, "B", "integer");
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

    }
    /// <summary>
    /// 用于恢复数据库数据
    /// </summary>
    [UnityEditor.MenuItem("SQL/Recover")]
    public static void Recover()
    {
        SQLComponent.OpenConnect();
        SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { "isNewUser", "0" }, new string[] { "id", "12" });
        SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { "GlobalSoundVolume", "0.6" }, new string[] { "id", "12" });
        SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { "IsMute", "0" }, new string[] { "id", "12" });
        SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { "BGMVolume", "0" }, new string[] { "id", "12" });
        SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { "IsMuteBGM", "0" }, new string[] { "id", "12" });
        SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { "Frequency", "150" }, new string[] { "id", "12" });
        SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { "Amplitude", "0.6" }, new string[] { "id", "12" });
        Debug.Log("数据复原");
        SQLComponent.CloseDB();
    }
#endif
}
