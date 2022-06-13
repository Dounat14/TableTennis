using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    public AudioClip audioSource;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = audioSource;
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Bat")
            GetComponent<AudioSource>().Play();
        if (col.gameObject.name == "Tabletennis")
            GetComponent<AudioSource>().Play();
    }
}
