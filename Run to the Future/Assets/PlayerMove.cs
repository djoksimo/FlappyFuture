using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization
    public Rigidbody teslaPlayer;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 1500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        teslaPlayer.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")) {
            teslaPlayer.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            teslaPlayer.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            teslaPlayer.AddForce(0,upwardForce * Time.deltaTime, 0);
        }
    }

    
}
