using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceck_system : MonoBehaviour
{
    public GameObject[] 关闭的物体;
    void Start()
    {
         if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.LinuxPlayer)
        {
            Debug.Log("正在PC上运行");
        }
        else if (Application.platform == RuntimePlatform.Android)
        {
            OVRPlugin.SystemHeadset headsetType = OVRPlugin.GetSystemHeadsetType();

            switch (headsetType)
            {
                case OVRPlugin.SystemHeadset.Oculus_Quest:
                    Debug.Log("当前设备是Quest 1");
                    close_obj();
                    break;
                case OVRPlugin.SystemHeadset.Oculus_Quest_2:
                    Debug.Log("当前设备是Quest 2");
                  //  close_obj();
                    break;
                default:
                    Debug.Log("当前设备不是Quest系列，可能是其他Oculus设备或未知设备");
                    break;
            }
        }
        else
        {
            Debug.Log("当前不是在Android平台上运行，可能是通过PC运行的");
        }
    }


    private void close_obj()
    {
        if(关闭的物体.Length!=0)
        {
            foreach (var item in 关闭的物体)
            {
                item.SetActive(false);
            }
        }
    }
}
