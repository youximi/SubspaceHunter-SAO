using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_switch : MonoBehaviour
{
    public GameObject Weapon_inPack;
    public GameObject Weapon_inHand;
   
   public void Get_weapon_inHand()
   {
        Weapon_inPack.SetActive(false);
        Weapon_inHand.SetActive(true);
   }

   public void rePack_weapon()
   {
        Weapon_inPack.SetActive(true);
        Weapon_inHand.SetActive(false);
   }

}
