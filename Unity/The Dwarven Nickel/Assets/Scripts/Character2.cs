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
    public Text HealthText2;
    public bool player2hasWon = false;

    public AudioClip playerTwoDead;
    public AudioClip playerTwoWin;
    public AudioClip roundOver;



    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GameObject.Find("PlayerTwoDead").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((name == "Player2") && itemsCollected >= 3)
        {
            GameOver.roundCompletedScore2++;
            player2hasWon = true;
            StartCoroutine(PlayerWin());
            StartCoroutine(GameOver.PlayerVictory());
            itemsCollected = 0;
        }
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
        //Debug.Log("here");
        ScoreCount2.text = "Player 2 Score = " + itemsCollected.ToString();
        HealthText2.text = "Player 2 Health = " + health.ToString() + "%";
    }
    void PlayerDeath()
    {

        if ((name == "Player2") && health <= 0)
        {
            source.PlayOneShot(playerTwoDead, 1F);
            GameObject.Find("Player2").GetComponent<GameManager>().deathCounter++;
            this.gameObject.SetActive(false);
            
        }
    }

    IEnumerator PlayerWin()
    {
        source.PlayOneShot(playerTwoWin, 1F);
        yield return new WaitForSeconds(3f);
        source.PlayOneShot(roundOver, 1F);
    }
}
