using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int Health;
	public float Speed;
	public GameObject Bullet;

	public int Direction = 1;
	public float FireTimer = 0;

    public float DirChangeTimer = 0;


	// Use this for initialization
	void Start () {
		
	}

    #region Update()
    // Update is called once per frame
    void Update()
    {
        changeEnemyTransform();
        shootBullet();
        destoryGameObject();

        changeDirectionRandomly();
    }

    private void changeDirectionRandomly()
    {
        DirChangeTimer -= Time.deltaTime;
        if (DirChangeTimer <= 0)
        {
            Direction *= -1;
            DirChangeTimer = UnityEngine.Random.Range(0.5f, 2.0f);
        }
    }

    /// <summary>
    /// Changes the enemy transform.
    /// </summary>
    void changeEnemyTransform()
    {
        transform.Translate(transform.right * Direction * Speed * Time.deltaTime);

        if (transform.position.x > 5)
            Direction = -1;
        else if (transform.position.x < -5)
            Direction = 1;
    }

    /// <summary>
    /// Shoots the bullet.
    /// </summary>
    void shootBullet()
    {

        FireTimer -= Time.deltaTime;
        if (FireTimer <= 0)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            FireTimer = UnityEngine.Random.Range(0.5f, 1.0f);
        }
    }

    /// <summary>
    /// Destories the game object.
    /// </summary>
    void destoryGameObject()
    {
        if (Health <= 0)
            Destroy(gameObject);
    }
} 
#endregion
