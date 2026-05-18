using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_model : MonoBehaviour
{

    public Boss_gerController boss_GerController;
    public ParticleSystem hit;
    private bool once;

    private void OnCollisionEnter(Collision other) {
        if(once==false)
        {
            once=true;
            
            hit.transform.gameObject.SetActive(true);
            boss_GerController.BatlleStart();
            
        }
    }

}
