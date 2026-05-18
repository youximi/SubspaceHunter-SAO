using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_2Pop_UI : MonoBehaviour
{
     public GameObject Hint_prefab;
      public string Gernerate_point;
   
    
    public void 标准生成()
    {
        //生成UI，并且把信息填入
        GameObject point=GameObject.FindWithTag(Gernerate_point);
        Player_UI_Controller uI_Controller=GameObject.FindWithTag("Player").GetComponent<Player_UI_Controller>();
       GameObject generation_ui = uI_Controller.Web_Generate_UI(Hint_prefab,point);
      
    }

     
}
