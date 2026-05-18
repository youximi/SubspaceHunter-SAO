using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class once_slashGer : MonoBehaviour
{
    public GameObject 剑气;
    public Transform 剑气生成点;
    public void Ger_flySlash()
    {
        Instantiate(剑气,剑气生成点.position,剑气生成点.rotation);
    }
}
