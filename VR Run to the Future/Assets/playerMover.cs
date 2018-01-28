using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour {

	public Rigidbody playerPlane;
	public float forceConst, jumpConst;
    public float angle = Mathf.PI / 2;
    public 

	void Start () {
		playerPlane.AddForce (0, 0, forceConst);
	}

    public void Jump()
    {
        playerPlane.AddForce(Mathf.Cos(angle)*jumpConst, Mathf.Sin(angle) * jumpConst, 0);
    }
    
}
