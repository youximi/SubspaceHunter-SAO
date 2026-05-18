using System.Collections;
using System.Collections.Generic;
using Knife.Effects.SimpleController;
using UnityEngine;

public class Dual_pistol_controller : MonoBehaviour
{
   public GameObject Gun_one_backpack;
   public GameObject Gun_one_inHand;

   public void Gun_model_switch()
   {
        if(Gun_one_backpack.activeSelf)
        {
            Gun_one_backpack.SetActive(false);
            Gun_one_inHand.SetActive(true);
        }
        else
        {
            Gun_one_backpack.SetActive(true);
            Gun_one_inHand.SetActive(false);
        }
   }

    public void Gun_around_true()
    {
        print("进入转枪");
         transform.GetComponent<Animator>().SetBool("Gun_around",true);
    }

    public void Gun_around_false()
    {
         transform.GetComponent<Animator>().SetBool("Gun_around",false);
    }

}
