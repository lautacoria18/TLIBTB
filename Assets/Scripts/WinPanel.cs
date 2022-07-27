using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   
    public void selectLevel(string scene)
    {

        SceneManager.LoadScene(scene);
    }

    public void MainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
