using UnityEngine;
using System.Collections;

public class ProgressBar : MonoBehaviour
{
    public float barDisplay; 
    public Vector2 barPosition = new Vector2(20, 80);
    public Vector2 barSize = new Vector2(50, 80);
    public Texture2D depletedTexture;
    public Texture2D filledTexture;

    void OnGUI()
    {
        //draw the background
        GUI.BeginGroup(new Rect(barPosition.x, barPosition.y, barSize.x, barSize.y));
        GUI.Box(new Rect(0, 0, barSize.x, barSize.y), depletedTexture);

        //draw the filled in part
        GUI.BeginGroup(new Rect(0, 0, barSize.x * barDisplay, barSize.y));
        GUI.Box(new Rect(0, 0, barSize.x, barSize.y), filledTexture);
        GUI.EndGroup();
        GUI.EndGroup();
    }

    void Update()
    {
        //barDisplay = GameObject.Find("Player1").GetComponent<Character>().itemsCollected * 0.2f; // modify this to change how quickly the bar fills
    }
}
