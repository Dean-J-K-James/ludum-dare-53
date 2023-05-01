using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour, IInteractEvent
{
    public Item key;
    public LevelManager levelManager;

    public void OnInteract(NodeManager nodeManager, Player player)
    {
        if (player.item == key)
        {
            player.item = null;
            player.SendMessage("OnPlayerChanged");

            levelManager.currentLevel++;

            UnityEngine.SceneManagement.SceneManager.LoadScene("scn-game");
        }
    }
}
