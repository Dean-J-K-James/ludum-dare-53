using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour, IOnEnteredEvent
{
    public void OnEntered(NodeManager nodeManager, Player player)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("scn-game");
    }
}
