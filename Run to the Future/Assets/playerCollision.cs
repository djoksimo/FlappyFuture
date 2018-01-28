using UnityEngine;

public class playerCollision : MonoBehaviour {

    public PlayerMove movement;

    void OnCollisionEnter(Collision collision)
    {
        //GameOver
        if(collision.collider.tag == "wall")
        {
            //Debug.Log("collision");
            movement.enabled = false;
        }
       
    }


}
