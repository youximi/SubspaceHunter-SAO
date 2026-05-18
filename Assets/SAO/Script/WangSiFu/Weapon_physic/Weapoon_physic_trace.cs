using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using Oculus.Interaction.Input;

public class Weapoon_physic_trace : MonoBehaviour
{
    
     [SerializeField, Interface(typeof(IHand))]
        private MonoBehaviour _hand;
        public IHand Hand;

         private Rigidbody rb;
        public Transform Target;
        public bool in_hand;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

     private void Awake() {
        Hand = _hand as IHand;
    }

    public void Set_inHand()
    {
        in_hand=true;
    }

    public void Set_removeHand()
    {
        in_hand=false;
    }
    
    private void FixedUpdate() {

        
                  //  _root.localPosition = handRootPose.position;
                  //  _root.localRotation = handRootPose.rotation;
           
        if(true==in_hand){
               // rb.velocity=(Target.transform.position-transform.position)/Time.fixedDeltaTime;
                /*  Quaternion rotationDifference=handRootPose.rotation*Quaternion.Inverse(transform.rotation);
                rotationDifference.ToAngleAxis(out float angleInDegree,out Vector3 rotationAxis);
                Vector3 rotationDifferenceInDegree=angleInDegree*rotationAxis;
                rb.angularVelocity=(rotationDifferenceInDegree*Mathf.Deg2Rad/Time.fixedDeltaTime*0.5f);*/
              //  rb.MoveRotation(Quaternion.Slerp(rb.rotation,
                 //   Target.transform.rotation, Time.fixedDeltaTime*30));

                 // if (Hand.GetRootPose(out Pose handRootPose))
                // {
                  //  _root.localPosition = handRootPose.position;
                  //  _root.localRotation = handRootPose.rotation;
            

                    rb.velocity=(Target.transform.position-transform.position)/Time.fixedDeltaTime;
                    /*  Quaternion rotationDifference=handRootPose.rotation*Quaternion.Inverse(transform.rotation);
                        rotationDifference.ToAngleAxis(out float angleInDegree,out Vector3 rotationAxis);
                        Vector3 rotationDifferenceInDegree=angleInDegree*rotationAxis;
                        rb.angularVelocity=(rotationDifferenceInDegree*Mathf.Deg2Rad/Time.fixedDeltaTime*0.5f);*/
                        rb.MoveRotation(Quaternion.Slerp(rb.rotation,
                        Target.transform.rotation, Time.fixedDeltaTime*30));

                //}
         }
         
    }
}
