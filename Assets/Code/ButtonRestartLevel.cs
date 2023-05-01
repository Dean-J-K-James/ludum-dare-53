using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRestartLevel : MonoBehaviour
{
    public void RestartLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("scn-game");
    }
}
