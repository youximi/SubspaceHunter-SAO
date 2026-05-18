using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp_animator_close : MonoBehaviour
{
    public Animator animator;

    public void Close_animator()
    {
        animator.enabled=false;
    }

}
