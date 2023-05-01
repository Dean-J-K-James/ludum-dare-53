using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryEvent : MonoBehaviour
{
    public Player player; //
    public Image  image;  //

    /**
     * 
     */
    public void OnPlayerChanged()
    {
        image.sprite = player.item?.sprite;
    }
}
