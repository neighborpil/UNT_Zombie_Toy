using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest : MonoBehaviour {

    public ParticleSystem particle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //particle.main.loop
            //particle.main.startDelay
            //particle.shape.shapeType


            Debug.Log(particle.isPlaying);
            if (particle.isPlaying)
                particle.Stop();
            else if(particle.isStopped)
                particle.Play();

        }	
	}
}
