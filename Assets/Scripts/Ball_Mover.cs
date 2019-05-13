using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Mover : MonoBehaviour {

	private Rigidbody rb;
	private string userInput;
	float ballSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		rb = GetComponent<Rigidbody> ();
		userInput = Input.inputString;

		if (userInput != "") {
			switch (userInput) {
			case "w":
				rb.AddForce (0, 0, ballSpeed);
				break;

			case "s":
				rb.AddForce (0, 0, -ballSpeed);
				break;

			case "a":
				rb.AddForce (-ballSpeed, 0, 0);
				break;

			case "d":
				rb.AddForce (ballSpeed, 0, 0);
				break;
			}
		}
	



		}

	}

