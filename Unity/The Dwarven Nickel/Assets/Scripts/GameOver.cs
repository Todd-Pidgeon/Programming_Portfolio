using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static Scene gameOverScene;
    public static int roundCompletedScore1;
    public static int roundCompletedScore2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(roundCompletedScore1 >=1 || roundCompletedScore2 >= 1)
        {
            Debug.Log("Gameover call");
            endGame();
        }
    }

    public static void endGame()
    {
        GameObject.Find("TheRealGameOver").gameObject.SetActive(true);
        
        //        TheRealGameOver.text = "Player 1 Score = " + itemsCollected.ToString();
            }
    public static IEnumerator PlayerVictory()
    {
        if (GameObject.Find("Player1").GetComponent<Character>().player1hasWon)
        {
            roundCompletedScore1++;
            GameObject.Find("Player1").GetComponent<Character>().player1hasWon = false;
        }

        if (GameObject.Find("Player2").GetComponent<Character2>().player2hasWon)
        {
            roundCompletedScore2++;
            GameObject.Find("Player2").GetComponent<Character2>().player2hasWon = false;

        }
        //Debug.Log("1");
        yield return new WaitForSeconds(6f);
        //Debug.Log("2");
        SceneManager.LoadScene(0);
        GameObject.Find("Player1").GetComponent<PlayerControl>().flippedControls = false;
        GameObject.Find("Player2").GetComponent<PlayerControl>().flippedControls = false;
        // player wins
    }
}
