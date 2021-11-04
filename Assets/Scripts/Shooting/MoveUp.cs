using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {
    public float speed = 40.0f;

    void Start() {
        
    }

    void Update() {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
