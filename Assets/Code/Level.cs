using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Level")]
public class Level : ScriptableObject
{
    public Texture2D texture; //
    public int spawnX; //
    public int spawnY; //
    public string message; //
}