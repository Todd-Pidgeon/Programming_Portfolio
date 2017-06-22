using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static AudioClip playerOneWin;
    public static AudioClip playerTwoWin;

    public static AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void endGame()
    {
        Debug.Log("You !have reached the end of the game!");
    }

    public static void PlayerOneVictory()
    {
        // player wins
        Debug.Log("hello bitch");
        source.PlayOneShot(playerOneWin, 1F);
    }

    public static void PlayerTwoVictory()
    {
        // player wins
        source.PlayOneShot(playerTwoWin, 1F);
    }
}
