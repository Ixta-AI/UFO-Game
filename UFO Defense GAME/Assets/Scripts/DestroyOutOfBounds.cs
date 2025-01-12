using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
    public GameManager gameManager;
    
    //private AudioSource gameOver;
    
    //public AudioClip gameOverSound;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //gameOver = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            //gameOver.PlayOneShot(gameOverSound, 1.0f);
            gameManager.isGameOver = true;
            Time.timeScale = 0;
        }
    }
}
