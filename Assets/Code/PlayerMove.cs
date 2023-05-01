//======================================================
//	Dean James - Pangean Flying Cactus - Ludum Dare 53
//======================================================

using UnityEngine;

/**
 * 
 */
public class PlayerMove : MonoBehaviour
{
    public NodeManager tileManager; //
    public Player      player;      //
    public float       speed;       //
    public bool        moving;      //

    /**
     * 
     */
    void Update()
    {
        int x = player.x;
        int y = player.y;

        if (!moving)
        {
            if (Input.GetKeyDown(KeyCode.W)) { y++; }
            if (Input.GetKeyDown(KeyCode.A)) { x--; }
            if (Input.GetKeyDown(KeyCode.S)) { y--; }
            if (Input.GetKeyDown(KeyCode.D)) { x++; }
        }


        var tile = tileManager.Get<Tile>(x, y);

        if (tile != null && (x != player.x || y != player.y))
        {
            if (tile.walk)
            {
                var oldTile = tileManager.GetGameObject<Tile>(player.x, player.y);

                if (oldTile != null)
                {
                    foreach (var e in oldTile.GetComponents<IOnExitedEvent>())
                    {
                        e.OnExited(tileManager, player);
                    }
                }

                player.x = x;
                player.y = y;
            }

            if (tile.interactable)
            {
                var go = tileManager.GetGameObject<Tile>(x, y);

                if (go != null)
                {
                    foreach (var e in go.GetComponents<IInteractEvent>())
                    {
                        e.OnInteract(tileManager, player);
                    }
                }
            }
            
        }

        if (Vector2.Distance(transform.position, new Vector2(player.x, player.y)) > 0.1f)
        {
            moving = true;
        }

        if (moving)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.x, player.y), Time.deltaTime * speed);

            if (Vector2.Distance(transform.position, new Vector2(player.x, player.y)) < 0.1f)
            {
                transform.position = new Vector2(player.x, player.y);
                moving = false;

                SendMessage("OnPlayerMove");

                var newTile = tileManager.GetGameObject<Tile>(player.x, player.y);

                if (newTile != null)
                {
                    foreach (var e in newTile.GetComponents<IOnEnteredEvent>())
                    {
                        e.OnEntered(tileManager, player);
                    }
                }
            }
        }

    }
}
