using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour, IInteractEvent
{
    public Tile box;
    public Tile floor;

    public void OnInteract(NodeManager nodeManager, Player player)
    {
        int x = Mathf.FloorToInt(transform.position.x);
        int y = Mathf.FloorToInt(transform.position.y);

        int offsetX = x - player.x;
        int offsetY = y - player.y;

        if (nodeManager.Get<Tile>(x + offsetX, y + offsetY) == floor)
        {
            nodeManager.Set(box, x + offsetX, y + offsetY);
            nodeManager.Set(floor, x, y);

            player.x = x;
            player.y = y;
        }
    }
}
