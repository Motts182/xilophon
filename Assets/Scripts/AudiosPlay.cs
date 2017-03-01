using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiosPlay : MonoBehaviour {

    AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
	}

    public void PlaySound() {
        audio.Play();
    }
}
