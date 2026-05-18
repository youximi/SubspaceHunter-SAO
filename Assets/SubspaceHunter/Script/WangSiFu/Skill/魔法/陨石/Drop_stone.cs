using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_stone : MonoBehaviour
{
    public Transform fireStone_gerPoint;
    public GameObject fireStone;
    
    public void Ger_fireStone_attack()
    {
         Instantiate(fireStone,fireStone_gerPoint.position,fireStone_gerPoint.rotation);
    }
}
