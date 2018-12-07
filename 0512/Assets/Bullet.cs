using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float Speed;
    public int Damage;
    public bool isPlayer;

	// Use this for initialization
	void Start () {
		
	}

    #region Update
    // Update is called once per frame
    void Update()
    {
        moveBullet();
        destroyBullet();
    }

    private void destroyBullet()
    {
        if (transform.position.z <= -1 || transform.position.z > 10)
            Destroy(gameObject);
    }

    private void moveBullet()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
    #endregion


    private void OnTriggerEnter(Collider other)
    {
        minusHealth(other);
    }

    private void minusHealth(Collider other)
    {
        if (isPlayer)
        {
            if(other.tag == "Enemy")
            {
                other.GetComponent<Enemy>().Health -= Damage;
                Destroy(gameObject);
            }
        }
        else if (!isPlayer) // enemy
        {
            if(other.tag == "Player")
            {
                other.GetComponent<Player>().Health -= Damage;
                Destroy(gameObject);
            }
        }
    }
}
