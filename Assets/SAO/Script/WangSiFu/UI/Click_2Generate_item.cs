using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_2Generate_item : MonoBehaviour
{
    //仅仅是暂时用来测试召唤的demo
    public GameObject item;

    public  void Generate_item()
    {
            GameObject point=GameObject.FindWithTag("Item_generate_point");
            Instantiate(item,point.transform.position,Quaternion.identity);
    }
}
