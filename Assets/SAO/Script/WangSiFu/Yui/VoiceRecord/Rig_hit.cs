using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rig_hit : MonoBehaviour
{
    public Transform guide;
    public AudioSource hit_sound;
    private bool falg;
    private void OnCollisionEnter(Collision other) {
        if(!falg)
        {
            falg=true;
                hit_sound.Play();
            guide.GetComponent<Destory_self>().enabled=true;
        }
            
    }
}
