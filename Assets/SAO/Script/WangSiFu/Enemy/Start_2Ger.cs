using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_2Ger : MonoBehaviour
{
    public GameObject ger_obj;
    // Start is called before the first frame update
    void Start()
    {
           Invoke("ger_enemey",5f);
    }
    private void ger_enemey()
    {
         Instantiate(ger_obj,transform.position,transform.rotation);
    }

   
}
