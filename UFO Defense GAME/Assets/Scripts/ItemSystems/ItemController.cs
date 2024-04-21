using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Item Item;
    public GameObject powerUP;

    public Color startColor = Color.magenta;
    public Color endColor = Color.white;
    [Range(0, 10)]
    public float speed = 1f;

    Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }

    private void Update()
    {
        render.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }

}
