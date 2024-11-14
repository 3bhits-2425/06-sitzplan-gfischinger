using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

//Klasse Sound muss Serialisierbar sein (auﬂerhalb runtime)

[System.Serializable]
public class Sound
{
    //instancevariable
    public string name;
    public AudioClip clip;

    [Range(0f, 1f)] public float volume;
    [Range(0.1f, 3f)] public float pitch;

    [HideInInspector] public AudioSource audioSource;

    // Plays Sound
    public void Play()
    {
        audioSource.Play();
    }
    public void Pause()
    {
        audioSource.Pause();
    }

    public void Stop()
    {
        audioSource.Stop();
    }

}