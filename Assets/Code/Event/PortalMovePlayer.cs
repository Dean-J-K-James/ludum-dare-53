using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOnEnteredEvent
{
    void OnEntered(NodeManager nodeManager, Player player);
}

public class PortalMovePlayer : MonoBehaviour, IOnEnteredEvent
{
    public Tile portalType; //

    public void OnEntered(NodeManager nodeManager, Player player)
    {
        //get current position.
        //get positon of paired portal.
        //move player to it.

        foreach (var item in FindObjectsOfType<PortalMovePlayer>())
        {
            if (item.portalType == portalType && item != this)
            {
                int x = Mathf.FloorToInt(item.transform.position.x);
                int y = Mathf.FloorToInt(item.transform.position.y);

                player.x = x;
                player.y = y;

                player.transform.position = new Vector2(player.x, player.y);
            }
        }
    }
}
