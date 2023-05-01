using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "LevelManager")]
public class LevelManager : ScriptableObject
{
    public int currentLevel; //
    public Level[] levels; //
}