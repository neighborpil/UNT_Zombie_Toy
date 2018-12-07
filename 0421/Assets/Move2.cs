using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour {

    public float Speed;
    public int Health;


    public Transform BlueLight;
    public Transform RedLight;
    public Transform GreenLight;

    Animator Anim;
    // Use this for initialization
    void Start()
    {
        Anim = GetComponent<Animator>();
        //Anim.SetInteger("Health", Health);
    }

    // Update is called once per frame
    void Update()
    {

        RedLight.LookAt(transform);
        BlueLight.LookAt(transform);
        GreenLight.LookAt(transform);

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Speed * Time.deltaTime);
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Speed * Time.deltaTime);
            //Anim.SetTrigger("DoorClose");

        }
        else
        {
            //Anim.SetBool("Move", false);

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door")
        {
            other.GetComponent<Animator>().SetTrigger("Open");
        }
    }
}
