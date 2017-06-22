using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {



	// Use this for initialization
	void Start () {
        for (int i = 0; i < 35; i++)
        {
            Instantiate((Resources.Load("explosiveDrop")), GameObject.Find("Dirt (" + Random.Range(1, GameObject.FindGameObjectsWithTag("Pickup").Length) + ")").transform.position + new Vector3(0, 0.1f, 0), Quaternion.identity);
        }

        for (int i = 0; i < 5; i++)
        {
            Instantiate((Resources.Load("itemDrop")), GameObject.Find("Dirt (" + Random.Range(1, GameObject.FindGameObjectsWithTag("Pickup").Length) + ")").transform.position + new Vector3(0, 0.11f, 0), Quaternion.identity);
        }
        //Debug.Log(Test);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
