﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareSoundController : MonoBehaviour
{

    bool isMouseOver = false;
    public AudioSource Sound;

    private void OnMouseEnter()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(30.0f, 187.0f, 248.0f, 1.0f); 
        Sound.Play(0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, 1.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMouseOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
            }
        }

    }
}
