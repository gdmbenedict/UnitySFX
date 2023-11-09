using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnStay : MonoBehaviour
{
    public AudioSource audioPlayer;

    //function called when object enters trigger volume
    private void OnTriggerEnter(Collider other)
    {
        audioPlayer.Play();
    }

    //function called when object exits trigger volume
    private void OnTriggerExit(Collider other)
    {
        audioPlayer.Pause();

    }
}
