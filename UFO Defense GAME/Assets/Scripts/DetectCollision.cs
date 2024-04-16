using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//detect collision 
    {
        Destroy(gameObject);//Destroy this object
        Destroy(other.gameObject);//Destroy hit object
    }
}
