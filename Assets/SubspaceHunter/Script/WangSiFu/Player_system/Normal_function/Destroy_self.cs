using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_self : MonoBehaviour
{
    public float time=10f;
   
    // Start is called before the first frame update
    void Start()
    {
      Destroy_self_delay();
    }

    private void Destroy_self_delay()
    {
        Destroy(transform.gameObject,time);
    }

}
