using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour {
    public static Locator Instance { get; private set; }
    public W4Pigeon W4Pigeon { get; private set; }
    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this);
            Debug.Log("1");
            return;
    }
        Instance = this;
        GameObject playerObj = GameObject.FindWithTag("Player");
        W4Pigeon = playerObj.GetComponent<W4Pigeon>();
    }
}