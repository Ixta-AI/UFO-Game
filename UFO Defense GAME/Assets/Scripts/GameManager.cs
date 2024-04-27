using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

    public AudioClip gameOverSound;

    private AudioSource gameOver;

    void Awake()//Starts before start (reset all values)
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()//Initialize game over text var
    {
        gameOverText = GameObject.Find("GameOverText");
        gameOverText.SetActive(false);
        gameOver = GetComponent<AudioSource>();
    }

   
    void Update()//Checking for game over condition
    {
        if(isGameOver) 
        {
            gameOver.PlayOneShot(gameOverSound, 1.0f);
            EndGame();
        }
    }

    public void EndGame()//End game method
    {
        gameOverText.gameObject.SetActive(true);//Reveal game over text
        Time.timeScale = 0;//Freeze time
    }
}
