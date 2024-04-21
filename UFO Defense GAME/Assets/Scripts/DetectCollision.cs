using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//detect collision 
    {
        if (!GameObject.FindWithTag("Player"))

        {
            Destroy(gameObject);//Destroy this object
            Destroy(other.gameObject);//Destroy hit object
        } else if (GameObject.FindWithTag("Enemy")) 
        {
            Destroy(gameObject);
        }
        
    }
}
