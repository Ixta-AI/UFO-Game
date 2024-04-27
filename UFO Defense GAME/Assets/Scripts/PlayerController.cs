using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 36f;
    public float xRange = 45f;

    public Transform blaster;

    public GameObject lazerBolt;

    public GameManager gameManager;

    private AudioSource playerAudio;
    private AudioSource enemyAudio;

    public AudioClip lazerSound;
    public AudioClip explosion;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
        enemyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Stores input values (left and right) to use as movement
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Test Keep player within left bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Test Keep player within Right bounds
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // if space bar is pressed fire lazerBolt
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {// Create LazerBolt at the blaster transform position maintaining the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
            
            playerAudio.PlayOneShot(lazerSound, 1.0f); //play sound when space bar is hit
            
        }
    }

    //Delete any object with a trigger that hits  the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        enemyAudio.PlayOneShot(explosion, 1f);
    }
}
