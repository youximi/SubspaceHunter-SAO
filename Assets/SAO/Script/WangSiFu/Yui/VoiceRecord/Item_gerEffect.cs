using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_gerEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("disable_self",1.6f); 
    }

    private void disable_self()
    {
        transform.gameObject.SetActive(false);
    }

    
}
