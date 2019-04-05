using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Audio;

public class Volumen : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetVolumen(float volumen)
    {
        mixer.SetFloat("volumeLevel", volumen);
    }
}
