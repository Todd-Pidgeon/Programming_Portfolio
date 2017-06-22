using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character2 : MonoBehaviour
{
    public int itemsCollected = 0;
    public int health = 100;
    public bool player2IsDead;
    public Text ScoreCount2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0) // prevent user from going too out of bounds in health, reset him
        {
            health = 0;
        }
        else if (health >= 100)
        {
            health = 100;
        }

        if (itemsCollected > GameObject.FindGameObjectsWithTag("Pickup").Length) // incase player somehow gather more than the largest possible amount, reset him
        {
            itemsCollected = GameObject.FindGameObjectsWithTag("Pickup").Length;
        }

        if (health == 0)
        {
            PlayerDeath();
        }

        ScoreCount2.text = "Player 2 Score = " + itemsCollected.ToString();
    }
    void PlayerDeath()
    {

        if ((name == "Player2") && health <= 0)
        {
            GameObject.Find("Player2").GetComponent<GameManager>().deathCounter++;
            this.gameObject.SetActive(false);

        }
    }
}
