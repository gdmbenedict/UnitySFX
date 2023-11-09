using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchOnStay : MonoBehaviour
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
        audioPlayer.Stop();
    }

    //function called every frame that an object is in a trigger volume
    private void OnTriggerStay(Collider other)
    {
        audioPlayer.pitch = 3 * Mathf.Sin(Time.time);
    }
}
