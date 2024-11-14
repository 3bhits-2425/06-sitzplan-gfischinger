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
        FindAnyObjectByType<AudioManager>().Play("Sound 1");
    }

    public void PauseAudio()
    {
        FindAnyObjectByType<AudioManager>().Pause("Sound 1");
    }

    public void ResetAudio()
    {
        myAudioSource.Stop();
    }

    public void TogglePlayPause()
    {
        if (myAudioSource.isPlaying)
        {
            FindAnyObjectByType<AudioManager>().Pause("Sound 1");
            playPauseButtonText.SetText("Play");
        }
        else
        {
            FindAnyObjectByType<AudioManager>().Play("Sound 1");
            playPauseButtonText.SetText("Pause");

        }
    }
}