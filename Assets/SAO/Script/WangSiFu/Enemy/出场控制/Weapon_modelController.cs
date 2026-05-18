using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_modelController : MonoBehaviour
{
    public MeshRenderer[] weapon_inHand;
    public MeshRenderer[] weapon_inBag;

    public GameObject[]  obj_inHand;
    public GameObject[]  obj_inBag;

    public GameObject[]  skill_actObject;
    public GameObject[]  skill_closeObject;


    public GameObject[] skill_middle_open;
    public GameObject[] skill_middle_close;
    public GameObject[] skill_end_open;
    public GameObject[] skill_end_close;
   
    public void Activate_weapon()
    {
        foreach (var item in weapon_inBag)
        {
            item.enabled=false;
        }
        foreach (var item in weapon_inHand)
        {
            item.enabled=true;
        }

        foreach (var item in obj_inHand)
        {
            item.SetActive(true);
        }

        foreach (var item in obj_inBag)
        {
            item.SetActive(false);
        }
    }

    public void Activate_skillStatus()
    {
        foreach (var item in skill_actObject)
        {
            item.SetActive(true);
        }
        foreach (var item in skill_closeObject)
        {
            item.SetActive(false);
        }
    }

    public void End_skillObjStatus()
    {
         foreach (var item in skill_actObject)
        {
            item.SetActive(false);
        }
        foreach (var item in skill_closeObject)
        {
            item.SetActive(true);
        }
    }

    public void Skill_Midlle()
    {
         foreach (var item in skill_middle_open)
        {
            item.SetActive(true);
        }

        foreach (var item in skill_middle_close)
        {
            item.SetActive(false);
        }
    }

     public void Skill_End()
    {
         foreach (var item in skill_end_open)
        {
            item.SetActive(true);
        }

        foreach (var item in skill_end_close)
        {
            item.SetActive(false);
        }
    }



}
