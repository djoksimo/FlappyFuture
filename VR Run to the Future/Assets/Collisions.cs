using UnityEngine;

public class Collisions : MonoBehaviour {

    public playerMover movement;
    
    
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Wall")
        {
            Debug.Log("hello");
            movement.enabled = false;
        }

    }


}
