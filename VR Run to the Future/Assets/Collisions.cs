using UnityEngine;

public class Collisions : MonoBehaviour {

    public Rigidbody movement;
    
    
    void OnCollisionEnter(Collision collisionInfo) {

       

        if(collisionInfo.collider.tag == "Wall")
        {
            
            
        }

    }


}
