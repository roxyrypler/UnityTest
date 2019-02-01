using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareScript : MonoBehaviour
{
    public AudioController AudioControllerScript;

    private void Start()
    {
        AudioControllerScript = GameObject.Find("AudioController").GetComponent<AudioController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        AudioControllerScript.snareSound();
        gameObject.GetComponent<SpriteRenderer>().color = new Color(252.0f, 255.0f, 0.0f, 1.0f);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, 1.0f);
    }
}
