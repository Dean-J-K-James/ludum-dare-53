using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePad : MonoBehaviour, IOnEnteredEvent
{
    public void OnEntered(NodeManager nodeManager, Player player)
    {
        foreach (var item in FindObjectsOfType<Toggle>())
        {
            var x = Mathf.FloorToInt(item.transform.position.x);
            var y = Mathf.FloorToInt(item.transform.position.y);

            nodeManager.Set(item.switchTo, x, y);
        }
    }
}
