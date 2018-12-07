using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace test
{
    public class Move : MonoBehaviour
    {

        public float Speed;
        public int Health;

        public Animator Anim;

        // Use this for initialization
        void Start()
        {
            Anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Speed * Time.deltaTime);
                Anim.SetTrigger("DoorClose");
            }
            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Speed * Time.deltaTime);
                Anim.SetTrigger("DoorClose");
            }
        }
    }
}

