using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float Speed;
    public int Damage;
	public bool isPlayer; // true : player, false : enemy

    public Material materia;
	// Use this for initialization
	void Start () {
		
	}

    #region Update()
    // Update is called once per frame
    void Update()
    {
        moveBullet();
        destroyBullet();

    }

    /// <summary>
    /// Moves the bullet.
    /// </summary>
    private void moveBullet()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    /// <summary>
    /// Destroies the bullet.
    /// </summary>
    private void destroyBullet()
    {
        // 총알이 매을 벗어나면 삭제
        if (transform.position.z <= -1 || transform.position.z > 10)
            Destroy(gameObject);
    }

    #endregion

    #region 기타 이베트
    /// <summary>
    /// 콜라이더끼리 경계가 붙어 있을 때
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionStay(Collision collision)
    {

    }

    /// <summary>
    /// 콜라이더끼리 경계가 붙어 있다 떨어질 때
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit(Collision collision)
    {

    }

    /// <summary>
    /// 콜라이더끼리 경계가 부딪혔을 때 실행
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other)
    {

    }

    /// <summary>
    /// 콜라이더끼리 겹쳐있는 동안 실행
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {

    }

    /// <summary>
    /// 콜라이더끼리 겹쳐있던게 떨어져 나갈 때 실행
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {

    } 
    #endregion

    #region OnTriggerEnter()
    /// <summary>
    /// 콜라이더끼리 겹칠 때 실행
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log (other.name);
        minusHealth(other);
    }

    /// <summary>
    /// Minuses the health.
    /// </summary>
    /// <param name="other">Other.</param>
    private void minusHealth(Collider other)
    {
        if (isPlayer)
        {
            if (other.tag == "Enemy")
            {
                other.GetComponent<Enemy>().Health -= Damage;
                Destroy(gameObject);
                // == Destroy(transform)
            }
        }
        else if (!isPlayer)
        {
            if (other.tag == "Player")
            {
                // Health
                other.GetComponent<Player>().Health -= Damage;
                // Color
                other.GetComponent<MeshRenderer>().material = materia;
                //other.GetComponent<MeshRenderer>().material.color = Color.red;

                Destroy(gameObject);

            }
        }
    } 
    #endregion

}
