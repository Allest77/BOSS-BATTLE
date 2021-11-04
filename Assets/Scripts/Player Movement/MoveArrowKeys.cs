using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrowKeys : MonoBehaviour {
    public float speed = 8.0f;
    public GameObject boss;
    float movementX, movementY;
    private Vector2 playerVelocity;

    void Start() {
        boss = GameObject.Find("Boss");
        movementX = 0;
        movementY = 0;
    }

    void Update() {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
