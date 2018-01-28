using UnityEngine;

public class playerMover : MonoBehaviour {

	public Rigidbody playerPlane;
	public float forceConst, jumpConst;
    public float angle = Mathf.PI / 2;
    public Transform CameraTransform; 

	void Start () {
		playerPlane.AddForce (0, 0, forceConst);
	}

    void Update()
    {
        angle = (Mathf.PI / 2) + (CameraTransform.rotation.z * Mathf.PI / 180f);   

        
    }

    public void Jump()
    {
        //playerPlane.AddForce(Mathf.Cos(angle)*jumpConst, Mathf.Sin(angle) * jumpConst, 0);
    }
    
}
