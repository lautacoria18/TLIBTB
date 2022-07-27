using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private bool starTaken;
    public string levelToLoad;
    public GameObject winPanel;

    public static bool levelWin;
    // Start is called before the first frame update
    void Start()
    {
        starTaken = false;
        winPanel.SetActive(false);
        levelWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Star")
        {
            Debug.Log("Estrella");
            starTaken = true;
            col.gameObject.SetActive(false);
        }
        else if (col.tag == "LevelWin"){
            Debug.Log("gano");
            if (starTaken)
            {
                levelWin = true;
                winPanel.SetActive(true);
                
               // SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
