using UnityEngine;

public class playerMover : MonoBehaviour {

	public Transform playerPos;
	public float forceConst, jumpConst;
    public float angle = Mathf.PI / 2;
    public Transform CameraTransform;

    public Rigidbody rb;

    public Vector3 accel = new Vector3(), vel = new Vector3();

    private float timeout = 0;

    private void Start()
    {
        accel.Set(0, -5, 0);
        vel.Set(0, 0, 10);
    }

    void Update()
    {
        vel.Set(vel.x + accel.x * Time.deltaTime, vel.y + accel.y * Time.deltaTime, vel.z + accel.z * Time.deltaTime);

        playerPos.position = new Vector3(playerPos.position.x + vel.x * Time.deltaTime, playerPos.position.y + vel.y * Time.deltaTime, playerPos.position.z + vel.z * Time.deltaTime);

        angle = CameraTransform.eulerAngles.z;

        if(rb.position.y < 4f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (angle > 180)
        {
            angle = 360 - angle;
            angle *= 0.5f;
            angle = 360 - angle;
        }
        else
        {
            angle *= 0.5f;
        }

        playerPos.eulerAngles = new Vector3(0, 0, angle);

    }

    public void Jump()
    {
        if (Time.time - timeout < 0.5) return;
        float i = -0.4f;
        if (angle > 180) i = 0.4f;
        vel.x = vel.x + Mathf.Cos(angle)*jumpConst*i;
        vel.y = vel.y + jumpConst;
        timeout = Time.time;
    }
    
}
