using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_meshManager : MonoBehaviour
{
    public GameObject[] weapon_mesh;  
    
    public void hide_weapon()
    {
        foreach (var item in weapon_mesh)
        {
            item.SetActive(false);
        }
    }

    public void Show_weapon()
    {
        foreach (var item in weapon_mesh)
        {
            item.SetActive(true);
        }
    }

}
