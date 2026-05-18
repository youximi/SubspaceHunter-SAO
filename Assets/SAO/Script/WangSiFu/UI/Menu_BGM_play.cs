using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_BGM_play : MonoBehaviour
{
    public AudioSource buttonClick_switch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void play_switchBGM()
    {
        buttonClick_switch.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
