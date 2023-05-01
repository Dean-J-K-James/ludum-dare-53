using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Node/Tile")] public class Tile : Entity
{
    public Sprite sprite; //
    public GameObject gameObject; //
    public bool   walk;   //
    public bool   interactable;   //

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        tileData.sprite = sprite;
        tileData.gameObject = gameObject;
    }
}