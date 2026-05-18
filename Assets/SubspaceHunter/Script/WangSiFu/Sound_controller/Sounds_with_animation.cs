using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds_with_animation : MonoBehaviour
{
    public AudioClip[] idle_sounds;
   public AudioClip[] anotice_sounds;
  

   public void play_idle_sounds()
   {
       int index=Random.Range(0,idle_sounds.Length*2);
       if(index<idle_sounds.Length)
       {
           GetComponent<AudioSource>().clip=idle_sounds[index];
           GetComponent<AudioSource>().Play();
       }

   }

  

   public void play_anotice_sounds()
   {
       int index=Random.Range(0,anotice_sounds.Length*2);
       if(index<anotice_sounds.Length)
       {
           GetComponent<AudioSource>().clip=anotice_sounds[index];
           GetComponent<AudioSource>().Play();
       }

   }
}
