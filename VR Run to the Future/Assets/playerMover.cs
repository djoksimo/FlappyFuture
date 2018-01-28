using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour {

	public Rigidbody playerPlane;
	public float forceConst; 

	void FixedUpdate () {
		playerPlane.AddForce (0, 0, forceConst*Time.deltaTime);
	}
}
