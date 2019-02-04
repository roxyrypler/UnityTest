using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    public GameObject line;
    public GameObject playeBtn;

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

    public void setBPM()
    {
        BPM = Slider.value;
    }

    // Update is called once per frame
    void Update()
    {


        if (isOverPlayButton)
        {
            if (Input.GetMouseButtonDown(0))
            {
                play = true;
            }
        }


        if (play)
        {
            if (line.transform.position.x >= 3.20)
            {
                line.transform.position = new Vector2(-3.10f, line.transform.position.y);
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
