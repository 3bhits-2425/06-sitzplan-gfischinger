using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Array of Sounds, which holds the sound data
    [SerializeField] private Sound[] sounds;
    private AudioManager singleton;

    void Awake()
    {
        if(singleton == null)
        {
            // noch kein AudioManager vorhanden
            // -> erzeuge einen
            singleton = this;
            // speichere die aktuelle Instanz im Singleton
        } else
        {
            // es existiert bereits ein AudioManager
            // -> zerstöre diesen
            Destroy(gameObject);
            return;
        }

        // Singleton soll nicht zerstört werden
        DontDestroyOnLoad(gameObject);

        foreach (Sound oneSound in sounds)
        {
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();

            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume = oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;
        }
    }

    // Plays Audio
    public void Play(string soundName)
    {
        FindSound(soundName).Play();
    }
    public void Pause(string soundName)
    {
        FindSound(soundName).Pause();
    }

    private Sound FindSound(string soundName)
    {
        foreach (Sound oneSound in sounds)
        {
            if (oneSound.name == soundName)
            {
                // sound gefunden
                Debug.Log("Sound gefunden");
                return oneSound;
            }
        }
        return null;
    }

   
}