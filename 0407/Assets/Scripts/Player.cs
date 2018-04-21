using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int Health;
	public float Speed;
	public GameObject Bullet;


	void Start () {
		
	}

    #region Update()
    void Update()
    {
        changePlayerTransform();
        shootBullet();
        destoryGameObject();
    }

    /// <summary>
    /// Changes the player transform.
    /// </summary>
    void changePlayerTransform()
    {
        transform.Translate(transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * Speed);

        if (transform.position.x > 5)
            transform.position = new Vector3(5, 0, 0);
        //transform.position.x = 5;
        else if (transform.position.x < -5)
            transform.position = new Vector3(-5, 0, 0);

    }

    /// <summary>
    /// Shoots the bullet.
    /// </summary>
    void shootBullet()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject _Bullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            _Bullet.GetComponent<Bullet>().isPlayer = true;
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
    #endregion
}
