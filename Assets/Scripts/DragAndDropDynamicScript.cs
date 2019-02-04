using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropDynamicScript : MonoBehaviour
{

    private Vector2 startPos;
    bool isDragging = false;
    bool isOverGridObj = false;
    bool doOnce = false;

    public GameObject kickSound;
    public GameObject snareSound;
    public GameObject hihatSound;
    public GameObject sound1;
    public GameObject sound2;
    public GameObject sound3;
    public GameObject sound4;
    public GameObject sound5;
    public GameObject sound6;

    Vector2 TempGridObjLoc;

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Line")
        {
            print("Jaja");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //print(collision.gameObject.name);
        if (collision.gameObject.name == "SoundHolder(Clone)")
        {
            isOverGridObj = true;
            TempGridObjLoc = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y);
        }
    }
    
    private void OnMouseExit()
    {
        isOverGridObj = false;
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bool mouseIsOver = gameObject.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (mouseIsOver)
            {
                isDragging = true;
            }
        } else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
        dragging(isDragging, mousePosition); 
    }

    void dragging(bool isDragging, Vector2 mousePos)
    {
        if (isDragging)
        {
            gameObject.transform.position = new Vector2(mousePos.x, mousePos.y);
            doOnce = true;
        }else if (!isDragging && isOverGridObj && doOnce)
        {
            gameObject.transform.position = new Vector2(startPos.x, startPos.y);
            if (gameObject.name == "Kick")
            {
                Instantiate(kickSound, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }else if (gameObject.name == "Snare")
            {
                Instantiate(snareSound, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }
            else if (gameObject.name == "Hi-Hat")
            {
                Instantiate(hihatSound, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }else if (gameObject.name == "Sound1")
            {
                Instantiate(sound1, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }
            else if (gameObject.name == "Sound2")
            {
                Instantiate(sound2, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }
            else if (gameObject.name == "Sound3")
            {
                Instantiate(sound3, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }
            else if (gameObject.name == "Sound4")
            {
                Instantiate(sound4, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }
            else if (gameObject.name == "Sound5")
            {
                Instantiate(sound5, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }
            else if (gameObject.name == "Sound6")
            {
                Instantiate(sound6, new Vector2(TempGridObjLoc.x, TempGridObjLoc.y), Quaternion.identity);
            }

            doOnce = false;
        }
    }
}
