using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    private int gridX = 8;
    private int gridY = 4;

    public GameObject SoundHolder;

    public List<GameObject> SoundHolderSpawned = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        gridSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gridSpawner()
    {
        for (var i = 0; i < gridX; i++)
        {
            for (var j = 0; j < gridY; j++)
            {
                SoundHolderSpawned.Add(Instantiate(SoundHolder, new Vector2((i * 0.8f) - 2.8f, (j * 0.8f) - 0.5f), Quaternion.identity));
            }
        }
        //var tempArr = SoundHolderSpawned.ToArray();
        
    }

    public void assignTag(GameObject[] tempArr)
    {
        for (var i = 0; i < tempArr.Length; i++)
        {
            tempArr[i].gameObject.name = "grid";
        }
    }
}
