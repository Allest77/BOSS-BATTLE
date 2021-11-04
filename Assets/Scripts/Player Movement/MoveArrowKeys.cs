using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrowKeys : MonoBehaviour {
    public float speed = 8.0f;
    float movementX, movementY;
    Rigidbody2D Rb;

    void Start() {
        Rb = GetComponent<Rigidbody2D>();
        movementX = 0;
        movementY = 0;
    }

    void Update() {
        Rb.velocity = new Vector2(movementX * speed * Time.deltaTime, movementY * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            movementY = 8;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            movementY = -8;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            movementX = -8;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            movementX = 8;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
            movementY = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) {
            movementX = 0;
        }
    }
}
