using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform teslaPlayer;
	public Vector3 offset;

	void Update(){
		transform.position = teslaPlayer.position + offset;
	}
		
}
