using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_all_child : MonoBehaviour
{ 
    public GameObject[] Child;

    public  void Activate_all_childs()
    {
        for(int i=0;i<Child.Length;i++)
        {
            Child[i].SetActive(true);
        }
    }
}
