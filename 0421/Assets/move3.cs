using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move3 : MonoBehaviour {

    public float Speed;

    public Transform BlueLight;
    public Transform RedLight;
    public Transform GreenLight;

    public NavMeshAgent Player;
    public Transform Target;

    // Use this for initialization
    void Start () {
        Player = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update () {

        BlueLight.LookAt(transform);
        RedLight.LookAt(transform);
        GreenLight.LookAt(transform);

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Speed * Time.deltaTime);
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Speed * Time.deltaTime);

        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Target.position = hit.point;
                Player.SetDestination(Target.position);

                //Player.SetDestination(hit.point);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Door")
        {
            other.GetComponent<Animator>().SetTrigger("DoorClose");
        }
    }
}
