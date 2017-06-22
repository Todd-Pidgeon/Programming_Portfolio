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

    public bool flippedRight;
    public bool flippedLeft;

    public bool flippedRight2;
    public bool flippedLeft2;


    void Start()
    {
        flippedRight = true;
        flippedLeft2 = true;
        PlayerRB = GetComponent<Rigidbody>();
        if (name == "Player1")
        {
        transform.Rotate(0, 0, 90);

        }
        if (name == "Player2")
        {
            transform.Rotate(0, 0, -90);
        }
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
                flippedRight2 = false;
                if (flippedControls)
                {
                    transform.position -= new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                }
                else
                {
                    if (!flippedLeft2)
                    {
                        flippedLeft2 = true;
                        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

                        transform.Rotate(0, 0, 180);
                    }
                    else {
                        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                    }

                }
            }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                flippedLeft2 = false;
                if (flippedControls)
                {
                    if (!flippedRight2)
                    {
                        flippedRight2 = true;
                        transform.position -= new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                        transform.Rotate(0, 0, 180);
                    }
                    else
                    {
                        transform.position -= new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

                    }
                }
                else
                {
                    if (!flippedRight2)
                    {
                        flippedRight2 = true;
                        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
                        transform.Rotate(0, 0, 180);

                    }
                    else
                    {
                        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

                    }
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
                flippedRight = false;
                if (flippedControls)
                {
                    transform.position -= new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                }
                else
                {
                    if (!flippedLeft)
                    {
                        flippedLeft = true;
                        transform.position += new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);

                        transform.Rotate(0, 0, 180);
                    }
                    else {
                        transform.position += new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                    }

                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                flippedLeft = false;
                if (flippedControls)
                {
                    if (!flippedRight)
                    {
                        flippedRight = true;
                        transform.position -= new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                        transform.Rotate(0, 0, 180);
                    }
                    else
                    {
                        transform.position -= new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);

                    }
                }
                else
                {
                    if (!flippedRight) { 
                        flippedRight = true;
                        transform.position += new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);
                        transform.Rotate(0, 0, 180);
                    }
                    else
                    {
                        transform.position += new Vector3(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, 0);

                    }
                }
            }
        }
    }
 }