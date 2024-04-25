using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

    void Awake()//Starts before start (reset all values)
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()//Initialize game over text var
    {
        gameOverText = GameObject.Find("GameOverText");
        gameOverText.SetActive(false);
    }

   
    void Update()//Checking for game over condition
    {
        if(isGameOver) 
        {
            EndGame();
        }
    }

    public void EndGame()//End game method
    {
        gameOverText.gameObject.SetActive(true);//Reveal game over text
        Time.timeScale = 0;//Freeze time
    }
}
