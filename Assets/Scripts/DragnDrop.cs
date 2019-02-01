using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{

    public GameObject kick;
    public GameObject snare;
    public GameObject hihat;

    public GameObject kickPrefab;
    public GameObject snarePrefab;
    public GameObject hihatPrefab;

    public GameObject[] soundholder;


    private bool mBDown = false;
    private bool isInGrid = false;
    private bool doOnce = false;
    private bool isHoldingKick = false;
    private bool isHoldeingHihat = false;
    private bool isHoldingSnare = false;

    private Vector2 gridSnapLoc;
    private Vector2 kickStartPos;
    private Vector2 hihatStartPos;
    private Vector2 snareStartPos;

    private void Start()
    {
        kickStartPos = new Vector2(kick.transform.position.x, kick.transform.position.y);
        hihatStartPos = new Vector2(hihat.transform.position.x, hihat.transform.position.y);
        snareStartPos = new Vector2(snare.transform.position.x, snare.transform.position.y);
    }

    public void getLocation(Vector2 locInput)
    {
        gridSnapLoc = new Vector2(locInput.x, locInput.y);
        isInGrid = true;
        //print(isInGrid);
    }

    public void leaveGrid()
    {
        isInGrid = false;
        //print(isInGrid);
    }

    // Update is called once per frame
    void Update()
    {

        //Gets the world position of the mouse on the screen        
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Checks whether the mouse is over the sprite
        bool kickSprite = kick.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);
        bool snareSprite = snare.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);
        bool hihatSprite = hihat.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            mBDown = true;
           
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            mBDown = false;
        }

        if (mBDown)
        {
            if (kickSprite)
            {
                kick.GetComponent<BoxCollider2D>().enabled = false;
                doOnce = true;
                isHoldingKick = true;

                if (isInGrid)
                {
                    kick.transform.position = new Vector2(gridSnapLoc.x, gridSnapLoc.y);
                }
                else
                {
                    kick.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0.0f);
                    
                }
            }else if (snareSprite)
            {
                snare.GetComponent<BoxCollider2D>().enabled = false;
                doOnce = true;
                isHoldingSnare = true;

                if (isInGrid)
                {
                    snare.transform.position = new Vector2(gridSnapLoc.x, gridSnapLoc.y);
                }
                else
                {
                    snare.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0.0f);

                }

            }else if (hihatSprite)
            {
                hihat.GetComponent<BoxCollider2D>().enabled = false;
                doOnce = true;
                isHoldeingHihat = true;

                if (isInGrid)
                {
                    hihat.transform.position = new Vector2(gridSnapLoc.x, gridSnapLoc.y);
                }
                else
                {
                    hihat.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0.0f);

                }
            }
        }else
        {
            if (doOnce)
            {
                kick.GetComponent<BoxCollider2D>().enabled = true;
                snare.GetComponent<BoxCollider2D>().enabled = true;
                hihat.GetComponent<BoxCollider2D>().enabled = true;
                spawnAndReset(kickSprite, snareSprite, hihatSprite);
                doOnce = false;
            }
        }
        
    }

    void spawnAndReset(bool kickSprite, bool snareSprite, bool hihatSprite)
    {
        if (isHoldingKick)
        {
            if (isInGrid && kickSprite)
            {
                Instantiate(kickPrefab, new Vector2(kick.transform.position.x, kick.transform.position.y), Quaternion.identity);
            }
        }else if (isHoldeingHihat)
        {
            if (isInGrid && hihatSprite)
            {
                Instantiate(hihatPrefab, new Vector2(hihat.transform.position.x, hihat.transform.position.y), Quaternion.identity);
            }
        }
        else if (isHoldingSnare)
        {
            if (isInGrid && snareSprite)
            {
                Instantiate(snarePrefab, new Vector2(snare.transform.position.x, snare.transform.position.y), Quaternion.identity);
            }
        }


        hihat.transform.position = new Vector2(hihatStartPos.x, hihatStartPos.y);
        kick.transform.position = new Vector2(kickStartPos.x, kickStartPos.y);
        snare.transform.position = new Vector2(snareStartPos.x, snareStartPos.y);
        isHoldingKick = false;
        isHoldeingHihat = false;
        isHoldingSnare = false;

    }

    
}
