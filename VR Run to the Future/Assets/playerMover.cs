using UnityEngine;

public class playerMover : MonoBehaviour {

	public Transform playerPos;
	public float forceConst, jumpConst;
    public float angle = Mathf.PI / 2;
    public Transform CameraTransform;

    public Vector3 accel = new Vector3(), vel = new Vector3();

    private float timeout = 0;

    private void Start()
    {
        accel.Set(0, -7, 0);
        vel.Set(0, 0, 10);
    }

    void Update()
    {
        vel.Set(vel.x + accel.x * Time.deltaTime, vel.y + accel.y * Time.deltaTime, vel.z + accel.z * Time.deltaTime);

        if (vel.x > 0) vel.x -= 0.01f;
        else if (vel.x < 0) vel.x += 0.01f;

        angle = CameraTransform.eulerAngles.z;
        playerPos.position = new Vector3(playerPos.position.x + (vel.x - Mathf.Sin(angle*Mathf.PI / 180f)*9f) * Time.deltaTime, playerPos.position.y + vel.y * Time.deltaTime, playerPos.position.z + vel.z * Time.deltaTime);

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
        vel.y = vel.y + jumpConst;
        timeout = Time.time;
    }
    
}
