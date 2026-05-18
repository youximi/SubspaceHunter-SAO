using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawn : MonoBehaviour
{
    public GameObject Enemy_prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Gernerate_enemy()
    {
        Instantiate(Enemy_prefab,transform.position,transform.rotation);
    }

    public void Delay_ger_Enemey()
    {
        Invoke("Gernerate_enemy",6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
