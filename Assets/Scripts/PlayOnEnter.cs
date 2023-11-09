using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnEnter : MonoBehaviour
{
    public AudioSource audioPlayer;

    //function called when object enters trigger volume
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioPlayer.Play();
        }
    }
}
