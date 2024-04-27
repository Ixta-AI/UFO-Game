using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager

    public int scoreToGive;

    private AudioSource enemyAudio;

    public AudioClip explosion;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>(); // Find ScoreManager game object and reference ScoreManager script component
        enemyAudio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)// When hitting other game object 
    {
        scoreManager.IncreaseScore(scoreToGive);// Increase the score

        if (!GameObject.FindWithTag("Player"))

        {
            Destroy(gameObject);//Destroy this object
            Destroy(other.gameObject);//Destroy hit object
        } 
        else if (other.gameObject.CompareTag("Enemy")) 
        {
            Destroy(other.gameObject);
            enemyAudio.PlayOneShot(explosion);
        }
        
    }
}
