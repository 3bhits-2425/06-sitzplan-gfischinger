using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensch : MonoBehaviour
{
    public string personenName;
    public string rolleInKlasse;
    public Color augenfarbe;
    [SerializeField] private AudioSource myAudioSource;
    void Start()
    {
        Debug.Log(personenName + rolleInKlasse + augenfarbe);

        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You Failed!");
            myAudioSource.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("You recombobulated");
            myAudioSource.Pause();
        }
    }
}
