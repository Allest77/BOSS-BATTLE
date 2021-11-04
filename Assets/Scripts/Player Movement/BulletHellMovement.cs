using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHellMovement : MonoBehaviour {
    public float speed = 4.0f;
    public GameObject gunner;
    float movementX, movementY;
    private CharacterController controller;
    private Vector2 playerVelocity;

    void Start() {
        gunner = GameObject.Find("Gunner");
        movementX = 0;
        movementY = 0;
    }

    //Gunner Controller
    void Update() {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        transform.Translate(movement * speed * Time.deltaTime);

        /*
        //transform.Rotate(speed2.x, speed2.y, 0);
        //playerVelocity = new Vector2(movementX * speed * Time.deltaTime, movementY * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W)) {
            movementY = speed;
            Debug.Log("poop");
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            movementY = -speed;
            Debug.Log("poop2");
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            movementX = -speed;
            Debug.Log("poop3");
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            movementX = speed;
            Debug.Log("poop4");
        }

        //To lock movement.
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) {
            movementY = 0;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) {
            movementX = 0;
        }
         */
    }
}
