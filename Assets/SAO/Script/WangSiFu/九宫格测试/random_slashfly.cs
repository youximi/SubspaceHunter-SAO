using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_slashfly : MonoBehaviour
{
    public GameObject 剑气;
    public Transform[] 生成点集合;
   

    
    public void Gerner_slash()
    {

        int i = UnityEngine.Random.Range(0,3);
        Instantiate(剑气,生成点集合[i].position,生成点集合[i].rotation);
     


    }

}
