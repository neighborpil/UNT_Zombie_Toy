using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);

        if (Vector3.Distance(Vector3.zero, transform.position) > 20)
        {
            gameObject.SetActive(false);

        }
    }
}
