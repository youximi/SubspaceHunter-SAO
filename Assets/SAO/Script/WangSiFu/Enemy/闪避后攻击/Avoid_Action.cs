using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avoid_Action : MonoBehaviour
{
   public int[] forwardAction;
   public int[] leftAction;
   public int[] rightAction;

   public int Get_forwardAction()
   {
        if(forwardAction.Length==0) return -1;
         return forwardAction[Random.Range(0,forwardAction.Length)];
   }
   public int Get_leftAction()
   {
        if(leftAction.Length==0) return -1;
         return leftAction[Random.Range(0,leftAction.Length)];
   }
   public int Get_rightAction()
   {
        if(rightAction.Length==0) return -1;
         return rightAction[Random.Range(0,rightAction.Length)];
   }


}
