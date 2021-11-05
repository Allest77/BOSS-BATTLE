using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour {
private float topBound = 30.0f, lowerBound = -10.0f;


    void Update() {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
        Destroy(gameObject);
        Debug.Log("Game Over"); //a string that displays a game over message in the console. 
        }
    }
}
