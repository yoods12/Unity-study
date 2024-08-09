using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text bestTimeText;

    private float s_Time;
    private bool isGameOver;

    void Start()
    {
        isGameOver = false;
        s_Time = 0;

    }

    void Update()
    {
        if(!isGameOver)
        {
            s_Time = s_Time + Time.deltaTime;
            timeText.text = "Time : " + (int)s_Time;
        }
        else
        {
            if(Input.GetKeyUp(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
            if(Input.GetKeyUp(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }

    public void EndGame()
    {
        isGameOver = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");
        if (s_Time > bestTime)
        {
            bestTime = s_Time;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        bestTimeText.text = "Best Time : " + (int)bestTime;
    }
}
