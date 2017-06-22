using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static Scene gameOverScene;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void endGame()
    {
        gameOverScene = SceneManager.CreateScene("GameOverScene");
        SceneManager.SetActiveScene(gameOverScene);
        Debug.Log("You !have reached the end of the game!");
    }
    public static void PlayerVictory()
    {
        SceneManager.LoadScene(0);
        // player wins
    }
}
