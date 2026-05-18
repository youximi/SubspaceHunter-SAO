using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SQL_Accesser : MonoBehaviour
{
    private IEnumerator worker;
    public static SQL_Accesser instance;

    static public string DatabaseName = "Test_table";

    public float connectTime = 1f;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
       // DontDestroyOnLoad(this.gameObject);

        worker = SQLComponent.copyDbFile();//因为是携程所以下面的会直接开启，不会按顺序
        StartCoroutine(worker);

        
          
        
       
        //Invoke("ConnectDatabase", connectTime);

    }
    private void OnDisable()
    {

        //StopAllCoroutines();//?这个问题吗
        //Debug.Log("Disable SQL_Caller");
        //CloseDatabase();
    }
    private void OnDestroy()
    {
      
    }
    private void OnApplicationQuit()
    {
        Debug.Log("摧毁");
        StopAllCoroutines();//?这个问题吗 感觉是这个问题 onDisable 如果dontdestyy应该不会调用吧？？？
        CloseDatabase();
        //https://blog.csdn.net/weixin_34081595/article/details/85755067 不同物体ondisable destry调用顺序不同
        //造成数据库关闭还会访问 即destroy比disable先调用
    }

    public void ConnectDatabase()
    {
        SQLComponent.OpenConnect();
    }
    public void CloseDatabase()
    {
        SQLComponent.CloseDB();
    }
    public void UpDateData()
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "isNewUser", "1" }, new string[] { "id", "12" });
    }
    public void UpdateVolumeData(float volume)//全局音量
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "GlobalSoundVolume", volume.ToString() }, new string[] { "id", "12" });
    }
    public void UpdateMuteData(int i)
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "IsMute", i.ToString() }, new string[] { "id", "12" });
    }
    public void UpdateBGMVolumeData(float volume)//BGM音量
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "BGMVolume", volume.ToString() }, new string[] { "id", "12" });
    }
    public void UpdateBGMMuteData(int i)//BGM禁用
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "IsMuteBGM", i.ToString() }, new string[] { "id", "12" });
    }
    public void UpdateFrequencyData(int volume)//全局音量
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "Frequency", volume.ToString() }, new string[] { "id", "12" });
    }
    public void UpdateAmplitudeData(float volume)//全局音量
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "Amplitude", volume.ToString() }, new string[] { "id", "12" });
    }
    public void UpdateVRorMR(int i)
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "VRMR", i.ToString() }, new string[] { "id", "12" });
    }
    public void ResetData()
    {
        SQLComponent.UpdataData(DatabaseName, new string[] { "isNewUser", "0" }, new string[] { "id", "12" });
    }
    public void InsertData()
    {

    }
    public void SelectData()
    {

        Debug.Log(SQLComponent.SelectData(DatabaseName, new string[] { "isNewUser" }, new string[] { "id", "12" }).GetValue(0));

    }

    public string WhichSceneToLoad()
    {
        string k = SQLComponent.SelectData(DatabaseName, new string[] { "isNewUser" }, new string[] { "id", "12" }).GetValue(0).ToString();
        //Debug.Log(i);
        //无法转int？
        return k;//0 没通过 1 通过
    }

    public string ReturnData( string type,string id)
    {
        string k = SQLComponent.SelectData(DatabaseName, new string[] { type }, new string[] { "id", id }).GetValue(0).ToString();
        return k;
    }

    public string LoadToMRorVR()
    {
        return SQLComponent.SelectData(DatabaseName, new string[] { "VRMR" }, new string[] { "id", "12" }).GetValue(0).ToString();
    }
    /// <summary>
    /// 每次更新前记得更新这个
    /// </summary>
    public void AddColumn()
    {
        UpdateDatabaseColumns("GlobalSoundVolume", "float", "0.6");
        UpdateDatabaseColumns("IsMute", "integer", "0");
        UpdateDatabaseColumns("BGMVolume", "float", "0.6");
        UpdateDatabaseColumns("IsMuteBGM", "int", "0");
        UpdateDatabaseColumns("Frequency", "int", "150");
        UpdateDatabaseColumns("Amplitude", "float", "0.6");
        UpdateDatabaseColumns("VRMR", "int", "1");//1 MR 0 VR
    }

    public  void UpdateDatabaseColumns(string columnName, string type, string value)
    {
        try
        {
            SQLComponent.AddColumn(SQL_Accesser.DatabaseName, columnName, type);//若失败直接跳出，不赋值，代表有column了
            SQLComponent.UpdataData(SQL_Accesser.DatabaseName, new string[] { columnName, value }, new string[] { "id", "12" });
            // SQLComponent.AddColumn(SQL_Accesser.DatabaseName, "B", "integer");
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

    }

}
