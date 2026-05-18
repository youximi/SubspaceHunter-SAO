using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirrio_movement : MonoBehaviour
{
  //  public Transform PlayerTarget;
    public Transform Mirror;
 

    // Update is called once per frame
    void Update()
    {
        Vector3 localPlayer = Mirror.InverseTransformPoint(Camera.main.transform.position);
        transform.position = Mirror.TransformPoint(new Vector3(localPlayer.x,localPlayer.y,-localPlayer.z));
        Vector3 look_at_Mirror = Mirror.TransformPoint(new Vector3(-localPlayer.x,localPlayer.y,localPlayer.z));
        transform.LookAt(look_at_Mirror);
    }
}
