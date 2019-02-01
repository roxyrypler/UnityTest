using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public int gridX = 4;
    public int gridY = 4;

    public GameObject SoundHolder;
    // Start is called before the first frame update
    void Start()
    {
        gridSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void gridSpawner()
    {
        for (var i = 0; i < gridX; i++)
        {
            for (var j = 0; j < gridY; j++)
            {
                Instantiate(SoundHolder, new Vector2((i * 0.8f) - 2.8f, (j * 0.8f) - 0.5f), Quaternion.identity);
            }
        }
    }
}
