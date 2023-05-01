using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetupScene : MonoBehaviour
{
    public LevelManager levelManager;

    void Start()
    {
        levelManager.currentLevel = 0;
        SceneManager.LoadScene("scn-game");
    }
}
