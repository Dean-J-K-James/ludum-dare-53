using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public NodeManager itemManager; //
    public Player player;      //

    void Start()
    {
        SendMessage("OnPlayerChanged");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && player.item != null && itemManager.Get<Item>(player.x, player.y) == null)
        {
            //Debug.Log("Dropping item: " + player.item.name);
            itemManager.Set(player.item, player.x, player.y);
            player.item = null;
            SendMessage("OnPlayerChanged");
        }
    }
}
