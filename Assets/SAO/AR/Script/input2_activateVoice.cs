using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;

public class input2_activateVoice : MonoBehaviour
{
   // Start is called before the first frame update
    public AppVoiceExperience appVoice;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            appVoice.Activate();
        }
    }
}
