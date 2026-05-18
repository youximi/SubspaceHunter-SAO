using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class releaseWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody goal;
    void Start()
    {
        
    }

    public void release_weopon()
    {
        print("进入解除静态");
        this.transform.GetComponent<Rigidbody>().isKinematic=false;
        if(goal) goal.isKinematic=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
