using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSelect : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {

        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void touch1()
    {
        audio.clip = clips[0];
        audio.Play();
    }

    public void touch2()
    {
        audio.clip = clips[1];
        audio.Play();
    }
    public void options()
    {
        audio.clip = clips[2];
        audio.Play();
    }
    public void sets()
    {
        switch (gameObject.name)
        {
            case "Set1":

                ; break;
            case "Set2":

                ; break;
            case "Set3":

                ; break;
        }
        audio.clip = clips[3];
        audio.Play();
    }
}
