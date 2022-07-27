using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static float timer = 0.0f;

    public Text timeText;
    public Text yourTime;
    public Text perfectTimeText;
    public GameObject perfectText;
    public float perfectTime;
    // Start is called before the first frame update
    void Start()
    {
               
        
        
        timer = 0.0f;
        //perfectTime = float.Parse(perfectTimeText.text);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.levelWin)
        {

            perfectTimeText.text = perfectTime.ToString();
            perfectText.SetActive(false);

            timeText.text = timeText.text;
            yourTime.text = timeText.text;
            float yourTimeFloat = float.Parse(yourTime.text);
            if (yourTimeFloat < perfectTime) {
                perfectText.SetActive(true);
            }
        }
        else
        {
            timer += Time.unscaledDeltaTime;
            timeText.text = timer.ToString("F2");
        }


    }
}
