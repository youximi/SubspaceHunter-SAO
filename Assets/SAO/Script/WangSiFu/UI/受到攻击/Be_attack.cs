using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Be_attack : MonoBehaviour
{
    
  // private bool is_wait;
    public float intervalTime=0.2f;
    void OnEnable()
    {

        Invoke("wait2Close",intervalTime);
    }

    private void  wait2Close()
    {
        // is_wait=false;
         transform.gameObject.SetActive(false);
    }
}
