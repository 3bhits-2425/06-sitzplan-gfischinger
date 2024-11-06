using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{

    private AudioSource myAudioSource;
    private GameObject playPauseButton;
    private TMP_Text playPauseButtonText;

    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        // das Textfeld des PlayPauseButton finden
        playPauseButton = GameObject.Find("PlayPauseButton");
        // Textfeld als Kind des Buttons finden
        playPauseButtonText = playPauseButton.GetComponentInChildren<TMP_Text>();
    }
    public void PlayAudio()
    {
        // Idee: Audio-Source

        // Spiele die Audio-Source
        myAudioSource.Play();
    }

    public void PauseAudio()
    {
        myAudioSource.Pause();
    }

    public void ResetAudio()
    {
        myAudioSource.Stop();
    }

    public void TogglePlayPauseAudio()
    {
        if (myAudioSource.isPlaying)
        {
            PauseAudio();
        }
        else
        {
            PlayAudio();
        }
    }

    public void Update()
    {
        // Ändere den Button-Text
        // abhängig vom Zustand dre AudioSource
        if (myAudioSource.isPlaying)
        {
            playPauseButtonText.SetText("Play");
        }
        else
        {
            playPauseButtonText.SetText("Pause");
        }
    }

}
