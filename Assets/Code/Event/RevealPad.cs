using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOnExitedEvent
{
    void OnExited(NodeManager nodeManager, Player player);
}

public class RevealPad : MonoBehaviour, IOnEnteredEvent, IOnExitedEvent
{
    public void OnEntered(NodeManager nodeManager, Player player)
    {
        foreach (var item in FindObjectsOfType<LavaHidden>())
        {
            item.spriteRenderer.color = Color.grey;
        }
    }

    public void OnExited(NodeManager nodeManager, Player player)
    {
        foreach (var item in FindObjectsOfType<LavaHidden>())
        {
            item.spriteRenderer.color = Color.white;
        }
    }
}
