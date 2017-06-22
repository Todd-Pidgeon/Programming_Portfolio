using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Action : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            GetComponent<Animation>().Play("Player1Action");
        }
    }
}
