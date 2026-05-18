using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_2AddRigbody : MonoBehaviour
{
   public void add_rigbody()
   {
       Rigidbody rb=transform.gameObject.AddComponent<Rigidbody>();
       // 设置使用Gravity
        rb.useGravity = true;

        // 设置Collision Detection类型为Continuous Dynamic
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

   }
}
