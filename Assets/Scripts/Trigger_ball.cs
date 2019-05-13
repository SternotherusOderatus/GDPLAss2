using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_ball : MonoBehaviour {

	GameObject ball;


	// Use this for initialization
	void Start () {

		ball = GameObject.Find ("Trigger");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider ball)
	{

		Destroy (GameObject.Find ("HighDrop_stuff"));

	}


}
