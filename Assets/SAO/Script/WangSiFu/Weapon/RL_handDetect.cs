using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_handDetect : MonoBehaviour
{
    public GameObject Weapon;
    private bool  is_set;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        init_weaponStatus();
    }

    public void init_weaponStatus()
    {
        is_set=false;
    }

    private void OnTriggerStay(Collider other) {
        if(Weapon.gameObject.tag!="Weapon"){return;}
        if(!is_set)
        {
            if(other.tag=="Player_leftHand")
            {
                Weapon.tag = "Weapon_inHand";
                is_set=true;
                if(Weapon.GetComponent<Physic_weaponManager>()!=null&&Weapon.GetComponent<Physic_weaponManager>().have_skill)
                 Weapon.GetComponent<Physic_weaponManager>().Get_Player().skill_LeftDisplay.Open_Display();
                transform.gameObject.SetActive(false);
            }else if(other.tag=="Player_rightHand")
            {
                 Weapon.tag = "Weapon_inRightHand";
                 is_set=true;
                 if(Weapon.GetComponent<Physic_weaponManager>()!=null&&Weapon.GetComponent<Physic_weaponManager>().have_skill)
                 Weapon.GetComponent<Physic_weaponManager>().Get_Player().skill_RightDisplay.Open_Display();
                transform.gameObject.SetActive(false);
            }
        }
    }

}
