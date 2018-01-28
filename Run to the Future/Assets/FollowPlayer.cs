using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform teslaPlayer;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = teslaPlayer.position + offset;
	}
}
