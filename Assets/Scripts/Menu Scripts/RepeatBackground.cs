using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour {
    private Vector3 startPos;
    private float repeatWidth;

    void Start() {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.y / 2; }

    void Update() {
        if (transform.position.y < startPos.y - 50) {
            transform.position = startPos; } }
}