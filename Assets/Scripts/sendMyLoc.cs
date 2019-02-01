using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendMyLoc : MonoBehaviour
{

    public DragnDrop DragnDropScript;
    private Vector2 thisLoc;

    void OnMouseEnter()
    {
        thisLoc = gameObject.transform.position;
        DragnDropScript.getLocation(thisLoc);
        //print("enter");
    }

    void OnMouseExit()
    {
        DragnDropScript.leaveGrid();
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
