using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickScript : MonoBehaviour
{
    public AudioController AudioControllerScript;

    private void Start()
    {
        AudioControllerScript = GameObject.Find("AudioController").GetComponent<AudioController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        AudioControllerScript.kickSound();
        gameObject.GetComponent<SpriteRenderer>().color = new Color(241.0f, 0.0f, 178.0f, 1.0f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, 1.0f);
    }
}
