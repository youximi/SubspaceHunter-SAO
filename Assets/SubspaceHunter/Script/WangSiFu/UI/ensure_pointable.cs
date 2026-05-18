using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class ensure_pointable : MonoBehaviour
{
   private bool  is_checked;
    private PointableCanvasModule  right_module;
    private CurvedUIInputModule error_module;

    // Start is called before the first frame update
    void Start()
    {
        right_module=GetComponent<PointableCanvasModule>();
    }

    // Update is called once per frame
    void Update()
    {
        if(right_module.enabled==false)
        {
            error_module=GetComponent<CurvedUIInputModule>();
            error_module.enabled=false;
            right_module.enabled=true;
        }
    }
}
