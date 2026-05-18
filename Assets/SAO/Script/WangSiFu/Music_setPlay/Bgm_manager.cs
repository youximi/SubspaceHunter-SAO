using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm_manager : MonoBehaviour
{
   public AudioSource start_bgm;
   public AudioSource Loop;
   public AudioSource End;

    private void Start() {
        start_bgm.Play();
        Invoke("paly_loop",4.5f);
    }
    
    private void paly_loop()
    {
        Loop.Play();
    }


   public void Play_End()
   {
       Loop.Stop();
       End.Play();
   }

   private void Update() {
       if(Input.GetKeyDown(KeyCode.E))
       {
           Play_End();
       }
   }
}
