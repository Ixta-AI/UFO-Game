using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager

    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>(); // Find ScoreManager game object and reference ScoreManager script component
    }
    void OnTriggerEnter(Collider other)// When hitting other game object 
    {
        scoreManager.IncreaseScore(scoreToGive);// Increase the score

        if (!GameObject.FindWithTag("Player"))

        {
            Destroy(gameObject);//Destroy this object
            Destroy(other.gameObject);//Destroy hit object
        } 
        else if (GameObject.FindWithTag("Enemy")) 
        {
            Destroy(gameObject);
        }
        
    }
}
