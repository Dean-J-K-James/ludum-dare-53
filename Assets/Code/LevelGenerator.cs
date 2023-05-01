using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public NodeManager nodeManager;
    public Tile tile;
    public Tile wall;
    public Tile portal;
    public Tile redDoor;
    public Item redKey;

    void Start()
    {
        for (int x = -4; x < 5; x++)
        {
            for(int y = -4; y < 5; y++)
            {
                if (Random.Range(0, 9) == 0)
                {
                    //tileManager.Set(wall, x, y);
                    nodeManager.Set(wall, x, y);
                }
                else
                {
                    nodeManager.Set(tile, x, y);
                }
            }
        }

        int i = Random.Range(-4, 5);
        int j = Random.Range(-4, 5);

        nodeManager.Set(redKey, i, j);

        i = Random.Range(-4, 5);
        j = Random.Range(-4, 5);

        nodeManager.Set(redDoor, i, j);

        i = Random.Range(-4, 5);
        j = Random.Range(-4, 5);

        nodeManager.Set(portal, i, j);

        i = Random.Range(-4, 5);
        j = Random.Range(-4, 5);

        nodeManager.Set(portal, i, j);
    }
}
