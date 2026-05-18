using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_high : MonoBehaviour
{
    public GameObject Hint_ground;
    private bool is_resetHight;
    
    private bool is_follow_controller;
    public MeshRenderer[] need_close;
   



    public void Start_resetHigh()
    {
        transform.position=new Vector3(transform.position.x,1.2f,transform.position.z);
        is_resetHight=true; 
        if(need_close.Length!=0)
        {
            foreach(var rende in need_close)
            {
                 rende.enabled=false;
            }
        }
        Hint_ground.SetActive(true);
    
    }

     public void Start_resetHigh_controller()
    {
        is_follow_controller=true;
        transform.position=new Vector3(transform.position.x,1.2f,transform.position.z);
        is_resetHight=true; 
        Hint_ground.SetActive(true);
    
    }


    public void End_ResetHigh()
    {
         if(need_close.Length!=0)
        {
            foreach(var rende in need_close)
            {
                 rende.enabled=true;
            }
        }
        is_resetHight=false;
        Hint_ground.SetActive(false);
      //  is_follow_controller=false;
    }

    private void FixedUpdate() {
        if(is_resetHight)
        {
                if(!is_follow_controller){
                    GameObject[] hands=GameObject.FindGameObjectsWithTag("anchor");
                    
                    foreach(var child in hands){
                        if(transform.position.y>child.transform.position.y)
                        {
                            transform.position=new Vector3(transform.position.x,child.transform.position.y,transform.position.z);
                        }
                    }
                }else
                {
                    GameObject[] hands=GameObject.FindGameObjectsWithTag("anchor_controller");
                    
                    foreach(var child in hands){
                        if(transform.position.y>child.transform.position.y)
                        {
                            transform.position=new Vector3(transform.position.x,child.transform.position.y,transform.position.z);
                        }
                    }
                }
        }
    }
    
}
