using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropDynamicScript : MonoBehaviour
{

    private Vector2 prewPos;
    bool isDragging = false;
    bool isOverGridObj = false;
    bool doOnce = false;

    Vector2 TempGridObjLoc;

    // Start is called before the first frame update
    void Start()
    {
        prewPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        print(collision.gameObject.name);
        isOverGridObj = true;
        TempGridObjLoc = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y);
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
            gameObject.transform.position = new Vector2(TempGridObjLoc.x, TempGridObjLoc.y);
            doOnce = false;
        }
    }
}
