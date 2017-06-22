// utilize this for the majority of events handled in the actual game world.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Text countText;
    public Vector3 Test;
    public bool player1IsDead = false;
    public bool player2IsDead = false;
    public int deathCounter;

    public AudioClip clink;
    public AudioClip pling;
    public AudioClip boom;

    private AudioSource source;

    // Use this for initialization
    void Start () {
        Physics.gravity = new Vector3(0f, -9.81f, -40f); // reverse gravity to affect the z axis
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerStay(Collider other)
    {
        if (name == "Player2")
        {
            if (other.gameObject.CompareTag("Pickup") && Input.GetKeyDown(KeyCode.Space))
            { 

                Destroy(other.gameObject);
                source.PlayOneShot(clink, 1F);
            }
            else if (other.gameObject.CompareTag("floor"))
            {
                if(name == "Player1")
                {
                    GameObject.Find("Player1").GetComponent<PlayerControl>().isGrounded = true;
                }
                else
                {
                    GameObject.Find("Player2").GetComponent<PlayerControl>().isGrounded = true;
                }
            }
        }

        if (name == "Player1")
        {
            if (other.gameObject.CompareTag("Pickup") && Input.GetKeyDown(KeyCode.Return))
            {

                Destroy(other.gameObject);
                source.PlayOneShot(clink, 1F);
            }
            else if (other.gameObject.CompareTag("floor"))
            {
                if (name == "Player2")
                {
                    GameObject.Find("Player1").GetComponent<PlayerControl>().isGrounded = true;
                }
                else
                {
                    GameObject.Find("Player2").GetComponent<PlayerControl>().isGrounded = true;
                }
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("dropoff") && name == "Player1")
        {
            GameObject.Find("Player1").GetComponent<Character>().itemsCollected *= 2; // add to collected

        }
        else if (other.gameObject.CompareTag("dropoff") && name == "Player2")
        {
            GameObject.Find("Player2").GetComponent<Character2>().itemsCollected *= 2; // add to collected

        }
        if (other.gameObject.CompareTag("item") && name == "Player1")
        {
            GameObject.Find("Player1").GetComponent<Character>().itemsCollected++; // add to collected
            Destroy(other.gameObject);
            source.PlayOneShot(pling, 1F);

        }
        else if(other.gameObject.CompareTag("item") && name == "Player2")
        {
            GameObject.Find("Player2").GetComponent<Character2>().itemsCollected++; // add to collected
            Destroy(other.gameObject);
            source.PlayOneShot(pling, 1F);

        }

        if (other.gameObject.CompareTag("explosive") && name == "Player1")
        {
            GameObject.Find("Player1").GetComponent<Character>().health -= 20; // damage player for touching explosive
            Destroy(other.gameObject);
            source.PlayOneShot(boom, 1F);
        }

        if (other.gameObject.CompareTag("explosive") && name == "Player2")
        {
            GameObject.Find("Player2").GetComponent<Character2>().health -= 20; // damage player for touching explosive
            Destroy(other.gameObject);
            source.PlayOneShot(boom, 1F);
        }
        if (other.gameObject.CompareTag("rare") &&( name == "Player1" || name == "Player2"))
        {
            GameObject.Find("Player1").GetComponent<PlayerControl>().flippedControls = true;
            GetComponent<PlayerControl>().flippedControls = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Pickup") || other.gameObject.CompareTag("floor")) // check if player is standing on a brick or floor and GROUND them
        {
            if(name == "Player1")
            {
                GameObject.Find("Player1").GetComponent<PlayerControl>().isGrounded = true;
            }

            if (name == "Player2")
            {
                GameObject.Find("Player2").GetComponent<PlayerControl>().isGrounded = true;
            }
        }
    }
}
