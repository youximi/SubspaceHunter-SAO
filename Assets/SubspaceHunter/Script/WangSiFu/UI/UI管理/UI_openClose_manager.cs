using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_openClose_manager : MonoBehaviour
{

    public GameObject[]  Deactivate_set;
    public Destory_self destory_Self;
    public GameObject[]  Display_content;
     public void DeActivate_UI()
   {
      
        if(Deactivate_set.Length!=0)
        {
            foreach (var item in Deactivate_set)
            {
                item.SetActive(false);
            }
        }

          if(null!=destory_Self)
       destory_Self.start_2waitDestroy();
       
   }

   public void Activate_UI()
   {
         if(Display_content.Length!=0)
        {
            foreach (var item in Display_content)
            {
                item.SetActive(true);
            }
        }
   }

   public void play_close_animator()
   {
      GetComponent<Animator>().SetTrigger("Close_box");
   }
}
