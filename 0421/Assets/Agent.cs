using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour {

    public NavMeshAgent Player;
    public Transform Target;
    //public Vector3 Target;

	// Use this for initialization
	void Start () {
        Player = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
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
}
