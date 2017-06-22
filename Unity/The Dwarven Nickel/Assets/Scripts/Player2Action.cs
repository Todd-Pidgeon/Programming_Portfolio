using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Action : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            GetComponent<Animation>().Play("Player2Action");
        }
    }
}
