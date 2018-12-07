using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int Health;
    public float Speed;
    public GameObject Bullet;

    public AudioClip shoot;
    public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        changePlayerTransform();
        shootBullet();
        destoryGameObject();
	}

    private void destoryGameObject()
    {
        if (Health <= 0)
            Destroy(gameObject);
    }

    private void shootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject _Bullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            _Bullet.GetComponent<Bullet>().isPlayer = true;

            playShootSound();
        }
    }

    private void playShootSound()
    {
        audio.PlayOneShot(shoot);
    }

    private void changePlayerTransform()
    {
        transform.Translate(transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * Speed);

        if (transform.position.x > 5)
            transform.position = new Vector3(5, 0, 0);
        else if (transform.position.x < -5)
            transform.position = new Vector3(-5, 0, 0);
    }
}
