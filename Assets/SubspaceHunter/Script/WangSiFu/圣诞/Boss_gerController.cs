using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_gerController : MonoBehaviour
{
    public GameObject Model;
    public GameObject[] Real_Body;
    public GameObject 雪橇;
    public bool is_autoStart=false;
    public float waitTime=26f;
    // Start is called before the first frame update
   
   private void Start() {
        Invoke("BatlleStart",waitTime);
   }


    public void BatlleStart()
    {
        Model.SetActive(false);
        foreach (var item in Real_Body)
        {   
            item.SetActive(true);
        }
    }

    public void Act_Model()
    {
        Model.SetActive(true);
    }
    public void close_sled()
    {
        雪橇.SetActive(false);
    }

    
}
