using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour {
    public static BGMScript bgInstance;

    private void Awake() {
        if (bgInstance != null && bgInstance != this) {
            Destroy(this.gameObject);
            return;
        }
        
        bgInstance = this;
        DontDestroyOnLoad(this);
    }
}