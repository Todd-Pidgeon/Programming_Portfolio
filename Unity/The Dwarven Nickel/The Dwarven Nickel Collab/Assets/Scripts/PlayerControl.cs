using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public bool flippedControls = false;
    public AudioClip pling;
    public AudioClip youWin;
    public float speed;

    public bool isGrounded = false;
    public Rigidbody PlayerRB;

    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (name == "Player1")
        {
            if (flippedControls)
            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    if (isGrounded)
                    {
                        isGrounded = false;
                        PlayerRB.AddForce(new Vector3(0, 0, 1000)); // adds force to the rigidbody attached to the player
                    }
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    if (isGrounded)
                    {
                        isGrounded = false;
                        PlayerRB.AddForce(new Vector3(0, 0, 1000)); // adds force to the rigidbody attached to the player
                    }
                }
            }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    if (flippedControls)
                    {
                        transform.position -= new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                    }
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    if (flippedControls)
                    {
                        transform.position -= new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                    }
            }
        } else if (name == "Player2")
        {
            if (flippedControls)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    if (isGrounded)
                    {
                        isGrounded = false;
                        PlayerRB.AddForce(new Vector3(0, 0, 1000)); // adds force to the rigidbody attached to the player
                    }
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.W))
            {
                if (isGrounded)
                {
                        isGrounded = false;
                        PlayerRB.AddForce(new Vector3(0, 0, 1000)); // adds force to the rigidbody attached to the player
                    }
                }
            }

            if (Input.GetKey(KeyCode.A))
            {
                if (flippedControls)
                {
                    transform.position -= new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                }
                else
                {
                    transform.position += new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (flippedControls)
                {
                    transform.position -= new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                }
                else
                {
                    transform.position += new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                }
            }
        }

    }
 }