using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnExit : MonoBehaviour
{
    public AudioSource audioPlayer;

    //function called when object exits trigger volume
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            audioPlayer.Play();
        }   
    }
}
