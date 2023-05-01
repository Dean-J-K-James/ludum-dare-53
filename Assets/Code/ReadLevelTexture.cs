using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ReadLevelTexture : MonoBehaviour
{
    public LevelManager levelManager; //
    public NodeManager nodeManager; //
    public EntityList entityList; //
    public Tile floor;
    public Player player; //
    public TextMeshProUGUI txtMessage; //

    Level level; //
    int sizex;
    int sizey;

    void Start()
    {
        level = levelManager.levels[levelManager.currentLevel];
        txtMessage.text = level.message;
        sizex = level.texture.width;
        sizey = level.texture.height;

        Camera.main.transform.position = new Vector3(sizex / 2f, sizey / 2f, -10);

        PlaceFloors();
        ReadTexture();

        //player.x = level.spawnX;
        //player.y = level.spawnY;

        player.transform.position = new Vector2(player.x, player.y);
    }

    void PlaceFloors()
    {
        for (int x = 0; x < sizex; x++)
            for (int y = 0; y < sizey; y++)
            {
                nodeManager.Set(floor, x, y);
            }
    }

    void ReadTexture()
    {
        var pixels = level.texture.GetPixels32();

        for (int i = 0; i < pixels.Length; i++)
        {
            int x = i % sizex;
            int y = i / sizex;

            var r = pixels[i].r;
            var g = pixels[i].g;
            var b = pixels[i].b;

            if (pixels[i].a == 0)
            {
                continue;
            }

            if (r == 255 && g == 255 && b == 255)
            {
                player.x = x;
                player.y = y;
                continue;
            }

            foreach (var e in entityList.entityList)
            {
                //Debug.Log("Testing: " + e.name);
                //Debug.Log("R: " + r + " :: " + e.colour.r + " :: " + (e.colour.r == r));

                if (e.colour.r == r && e.colour.g == g && e.colour.b == b)
                {
                    nodeManager.Set(e, x, y);

                    //Debug.Log(e.name + " " + x + " " + y + " " + pixels[i].ToString());

                    break;
                }
            }

        }
    }
}
