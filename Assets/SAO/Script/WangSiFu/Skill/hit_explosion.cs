using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_explosion : MonoBehaviour
{
    public GameObject Collusion_effect;
    public GameObject keep_effect;

   private void Collusion_counter(Collision other)
   {
        print("火球碰撞物体名字为："+other.gameObject.tag);
        Body_hit_Reaction body_Hit_Reaction = other.transform.GetComponent<Body_hit_Reaction>();
        if(null!=body_Hit_Reaction)
        {
            other.transform.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * 18000f, other.contacts[0].point);

        }
       GameObject tmp=Instantiate(Collusion_effect,new Vector3(transform.position.x,0,transform.position.z),Quaternion.identity);
       if(null!=keep_effect)
       Instantiate(keep_effect,new Vector3(transform.position.x,0,transform.position.z),Quaternion.identity);
       //Destroy(tmp,5f);
       Destroy(transform.gameObject);;
   }

   private void OnCollisionEnter(Collision other) {
       Collusion_counter(other);
   }
}
