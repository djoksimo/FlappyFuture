using UnityEngine;

public class Collisions : MonoBehaviour {

    public Rigidbody movement;
    
    
    void OnCollisionEnter(Collision collisionInfo) {

        //Debug.Log("hello");

        

        if(collisionInfo.collider.tag == "Wall")
        {
            //Debug.Log("helllo");
            FindObjectOfType<GameManager>().EndGame();
        }

    }


}
