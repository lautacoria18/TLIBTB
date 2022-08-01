using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public static bool starTaken;
    public string levelToLoad;
    public GameObject winPanel;

    public static bool levelWin;

    void Start()
    {
        starTaken = false;
        winPanel.SetActive(false);
        levelWin = false;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Star")
        {

            starTaken = true;
            col.gameObject.SetActive(false);
        }
        else if (col.tag == "LevelWin"){
            if (starTaken)
            {
                levelWin = true;
                winPanel.SetActive(true);
                
            }
        }
    }
}
