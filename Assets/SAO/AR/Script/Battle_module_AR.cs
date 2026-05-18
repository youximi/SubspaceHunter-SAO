using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_module_AR : MonoBehaviour
{
    public void Activate_battle_Module()
    {
       GameObject.FindWithTag("Battle_Target").GetComponent<Activate_all_child>().Activate_all_childs();
    }
}
