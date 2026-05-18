using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_plays : MonoBehaviour
{
    public AudioClip[] audio_set;
    // Start is called before the first frame update
    public void random_play()
    {
        int index=Random.Range(0,audio_set.Length);
        GetComponent<AudioSource>().clip=audio_set[index];
        GetComponent<AudioSource>().Play();
    }
}
