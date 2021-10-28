using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public GameObject BulletPrefab;
    public Transform spawnLocationRight, spawnLocationLeft;
    public bool canShoot, autoFire;
    public float coolDownDelay = 1f, burstDelay = 0.1f;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Z)) {
            canShoot = true;
            StartCoroutine(CoolDown());
        } else if (Input.GetKeyUp(KeyCode.Z)) {
            canShoot = false;
            StopCoroutine(CoolDown());
        }
    }

    IEnumerator CoolDown() {
        while (canShoot) {
            Debug.Log("shoot");
            yield return new WaitForSeconds(coolDownDelay);
            //Instantiate the bullet on the bulletTransform.
            Instantiate (BulletPrefab, spawnLocationRight.position, Quaternion.identity);
            Instantiate (BulletPrefab, spawnLocationLeft.position, Quaternion.identity);
        }
    }
    
    private void Shoot()
    {

    }
}
