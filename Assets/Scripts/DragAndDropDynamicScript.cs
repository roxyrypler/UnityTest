using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropDynamicScript : MonoBehaviour
{

    private Vector2 prewPos;
    bool isDragging = false;

    // Start is called before the first frame update
    void Start()
    {
        prewPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Hello");
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
        }
    }

    void snapToGrid()
    {
        
    }

    void getAllGridObj()
    {
        
    }
}
