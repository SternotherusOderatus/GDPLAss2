using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum_mover : MonoBehaviour {

	Rigidbody bodybody;

	// Use this for initialization
	void Start () {

		bodybody = GetComponent<Rigidbody>();


	}

	void OnCollisionEnter (Collision collision)
	{
		bodybody.constraints = RigidbodyConstraints.None;
	}
		
}
