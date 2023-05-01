using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemEvent : MonoBehaviour
{
    public NodeManager itemManager; //
    public Player player; //

    /**
     * 
     */
    public void OnPlayerMove()
    {
        var item = itemManager.Get<Item>(player.x, player.y);

        if (player.item == null && item != null)
        {
            player.item = item;

            itemManager.Set<Item>(null, player.x, player.y);
            SendMessage("OnPlayerChanged");
        }
    }
}
