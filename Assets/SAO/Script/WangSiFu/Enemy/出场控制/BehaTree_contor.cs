using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;


public class BehaTree_contor : MonoBehaviour
{
     public BehaviorTree tree;
     public AudioClip 出场嘶吼;
     public GameObject[] 出场特效;

     public void Monster_Roar()
     {
          GetComponent<AudioSource>().clip=出场嘶吼;
           GetComponent<AudioSource>().Play();
     }

     public void play_Enemy_effect()
     {
         foreach(var effect in 出场特效)
         {
             effect.GetComponent<ParticleSystem>().Play();
         }
     }
    
     public void enable_treeDesigner()
     {
         tree.enabled=true;
     }
    
}
