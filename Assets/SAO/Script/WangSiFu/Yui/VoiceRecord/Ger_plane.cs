using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ger_plane : MonoBehaviour
{
    public GameObject plane;
    public void Ger_plane_start()
    {
        GameObject temp = Instantiate(plane,transform.position,transform.rotation);
        Destroy(temp,10f);
    }
}
