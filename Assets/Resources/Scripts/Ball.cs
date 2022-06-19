using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    public AudioClip audioSource;
    public Rigidbody rigidbody;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = audioSource;
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Bat1"|| col.gameObject.name == "table1" || col.gameObject.name == "table2" || col.gameObject.name=="Bat2")
            GetComponent<AudioSource>().Play();
    }
    private void Update()
    {
        if(rigidbody.isKinematic)
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
    }

}
