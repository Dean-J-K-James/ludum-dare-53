using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractEvent
{
    void OnInteract(NodeManager nodeManager, Player player);
}

public class OpenDoor : MonoBehaviour, IInteractEvent
{
    public Item key;
    public Tile tile;

    public void OnInteract(NodeManager nodeManager, Player player)
    {
        if (player.item == key)
        {
            player.item = null;
            player.SendMessage("OnPlayerChanged");

            int x = Mathf.FloorToInt(transform.position.x);
            int y = Mathf.FloorToInt(transform.position.y);

            nodeManager.Set(tile, x, y);
        }
    }
}
