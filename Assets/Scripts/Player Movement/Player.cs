using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Controller2D))]
public class Player : MonoBehaviour {
    Vector3 velocity;
    public float speed = 6, gravity, jumpHeight = 4, timeToJumpApex = .4f, jumpVelocity, velocityXSmoothing, accerlationTimeAirborne = .2f, accerlationTimeGrounded = .1f;
    Controller2D controller;

    void Start() {
        controller = GetComponent<Controller2D>();

        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex, 2); //KINETIC FORMULA
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        print("Gravity: " + gravity + " Jump Velocity: " + jumpVelocity);
    }

    void Update() {
        if (controller.collisions.above || controller.collisions.below) {
            velocity.y = 0;
        }
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if(Input.GetKeyDown(KeyCode.Space) && controller.collisions.below) {
            velocity.y = jumpVelocity;
        }

        float targetVelocityX = input.x * speed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below)?accerlationTimeGrounded:accerlationTimeAirborne);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
