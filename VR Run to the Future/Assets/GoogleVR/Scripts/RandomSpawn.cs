using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {
  
    
    public Transform parentObject;

    void Start()
    { 
        for (int i = 0; i < 10; i++)
        {
            Instantiate(parentObject, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }

        


}

