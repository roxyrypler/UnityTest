using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    public GameObject line;
    public GameObject playeBtn;

    public AudioSource kickClip;
    public AudioSource hiHatClip;
    public AudioSource snareClip;

    public Slider Slider;

    private bool play = false;
    private bool isOverPlayButton = false;

    public float BPM = 0.01f;


    public void isOverBtn()
    {
        isOverPlayButton = true;
    }

    public void isNotOverBtn()
    {
        isOverPlayButton = false;
    }

    public void kickSound()
    {
        kickClip.Play(0);
    }

    public void hiHatSound()
    {
        hiHatClip.Play(0);
    }

    public void snareSound()
    {
        snareClip.Play(0);
    }


   

    // Update is called once per frame
    void Update()
    {

        BPM = Slider.value;

        if (isOverPlayButton)
        {
            if (Input.GetMouseButtonDown(0))
            {
                play = true;
            }
        }


        if (play)
        {
            if (line.transform.position.x >= 3.27)
            {
                line.transform.position = new Vector2(-3.24f, line.transform.position.y);
            }
            else if (line.transform.position.x <= -3.25)
            {
                line.transform.position = new Vector2(3.25f, line.transform.position.y);
            }
            else
            {
                line.transform.position = new Vector2(line.transform.position.x + BPM, line.transform.position.y);
            }
        } 
    }
}
