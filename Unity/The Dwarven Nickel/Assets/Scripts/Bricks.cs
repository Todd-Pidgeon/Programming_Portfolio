using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
    public int hitCounter;

	// Use this for initialization
	void Start () {
        hitCounter = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (hitCounter <= 0) {
            hitCounter = 2;
        }
	}
}
/*
This script be borked yo
fix sometime to give each instantiated object it's own unique attribute 
to track howm many hits it needs to be destroyed
*/
