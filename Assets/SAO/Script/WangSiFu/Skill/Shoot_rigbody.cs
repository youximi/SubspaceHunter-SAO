using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_rigbody : MonoBehaviour
{
   public GameObject Fire_prefab;

  
    // Start is called before the first frame update
   
    public void Shoot_fire()
    {
      
        GameObject fire_ball=Instantiate(Fire_prefab,transform.position,transform.rotation) ;
        fire_ball.transform.SetParent(null);
        fire_ball.GetComponent<Rigidbody>().AddForce(fire_ball.transform.forward*25,ForceMode.Impulse);
    }
}
