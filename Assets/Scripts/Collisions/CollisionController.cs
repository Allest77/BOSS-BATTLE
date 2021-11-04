using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {
    public HealthbarController healthbar;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Bullet") {
            if (healthbar) {
                //healthbar.onTakeDamage(10);
            }
        }
    }
}
