//======================================================
//	Dean James - Pangean Flying Cactus - Ludum Dare 53
//======================================================

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class NodeManager : MonoBehaviour
{
    public Tilemap tilemap;
    public Tilemap itemmap;

    public void Set<T>(T node, int x, int y) where T : TileBase
    {
        if ((node?.GetType() ?? typeof(T)) == typeof(Tile)) { tilemap.SetTile(new Vector3Int(x, y, 0), node); }
        if ((node?.GetType() ?? typeof(T)) == typeof(Item)) { itemmap.SetTile(new Vector3Int(x, y, 0), node); }
    }

    public T Get<T>(int x, int y) where T : TileBase
    {
        if (typeof(T) == typeof(Tile)) { return tilemap.GetTile(new Vector3Int(x, y, 0)) as T; }
        if (typeof(T) == typeof(Item)) { return itemmap.GetTile(new Vector3Int(x, y, 0)) as T; }

        return default;
    }

    public GameObject GetGameObject<T>(int x, int y)
    {
        if (typeof(T) == typeof(Tile)) { return tilemap.GetInstantiatedObject(new Vector3Int(x, y, 0)); }
        if (typeof(T) == typeof(Item)) { return itemmap.GetInstantiatedObject(new Vector3Int(x, y, 0)); }

        return default;
    }
}