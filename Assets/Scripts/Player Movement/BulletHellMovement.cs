using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHellMovement : MonoBehaviour {
    public float speed = 4.0f;
    float movementX, movementY;
    Rigidbody2D Rb;

    void Start() {
        Rb = GetComponent<Rigidbody2D>();
        movementX = 0;
        movementY = 0;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            movementY = 8;
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            movementY = -8;
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            movementX = -8;
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            movementX = 8;
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) {
            movementY = 0;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) {
            movementX = 0;
        }
    }
}
