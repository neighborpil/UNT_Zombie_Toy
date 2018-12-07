using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour {

    public AudioClip HurtAudio;
    public AudioClip DeathAudio;

    public AudioSource audio;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //audio.clip = HurtAudio;
            //audio.Play();
            //audio.PlayOneShot(HurtAudio);
            if (audio.isPlaying)
                audio.Pause();
            else
                audio.Play();
        }
	}
}
