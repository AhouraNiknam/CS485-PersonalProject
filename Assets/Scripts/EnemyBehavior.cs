using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour {
    /*
    private NavMeshAgent agent;
    public Transform target;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        agent.SetDestination(target.position);
    }
    */

    public Transform target;
    public float speed;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        //speed = 1f;
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target, Vector3.up);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
