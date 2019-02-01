using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiHatScript : MonoBehaviour
{
    public AudioController AudioControllerScript;

    private void Start()
    {
        AudioControllerScript = GameObject.Find("AudioController").GetComponent<AudioController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        AudioControllerScript.hiHatSound();
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0.0f, 255.0f, 23.0f, 1.0f);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, 1.0f);
    }
}
