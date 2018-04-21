using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject testobject;
    public float speed = 3;
    void Awake()
    {
    }

    void Start()
    {
        Time.timeScale = 2;
    }

    void Update()
    {      
        if (Input.GetAxis("Horizontal") != 0)
        {
            testobject.transform.Translate(
                new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            testobject.transform.Translate(
                new Vector3(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime));
        }
    }
}
