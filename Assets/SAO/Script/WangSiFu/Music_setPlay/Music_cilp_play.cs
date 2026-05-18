using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_cilp_play : MonoBehaviour
{
    // Start is called before the first frame update
   public AudioClip[] clip;

   public void Play_standardOpen_music()
   {
       AudioSource audios=GetComponent<AudioSource>();
       audios.clip=clip[0];
       audios.Play();
   }

   public void Play_standardClose_music()
   {
         AudioSource audios=GameObject.FindWithTag("Global_Music_play").GetComponent<AudioSource>();
       audios.clip=clip[1];
       audios.Play();
   }

   public void Play_Close_music_self()
   {
         AudioSource audios=GetComponent<AudioSource>();
       audios.clip=clip[1];
       audios.Play();
   }

}
