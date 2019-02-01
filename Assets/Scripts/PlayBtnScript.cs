using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtnScript : MonoBehaviour
{

    public AudioController AudioControllercript;

    void OnMouseEnter()
    {
        AudioControllercript.isOverBtn();
    }

    void OnMouseExit()
    {
        AudioControllercript.isNotOverBtn();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
