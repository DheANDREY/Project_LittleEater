using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelGenerator : MonoBehaviour
{
    public static readonly string[] TileTypes = new string[]
    {
        "Boss",
        "Chest",
        "Exit",
        "Normal",
        "Start"
    };

    [SerializeField] private int _gridWidth = 5;
    [SerializeField] private int _gridHeight = 3;

    [SerializeField] private int _tilemapWidth = 12;
    [SerializeField] private int _tilemapHeight = 12;

    // 1: kiri bawah
    // 2: tengah bawah
    // 3: kanan bawah
    // 4: kiri tengah
    // 5: kanan tengah
    // 6: kiri atas
    // 7: tengah atas 
    // 8: kanan atas
    // 9: tengah tengah

    // semakin kebawah, z semakin minus

    private void Awake()
    {
        Generate();

        transform.position = new Vector3(_tilemapWidth * _gridWidth * -0.5f, _tilemapHeight * _gridHeight * 0.5f);
    }

    [ContextMenu("Generate")]
    private void Generate()
    {
        Cleanup();

        #region generate tiles
        int[,] tiles = new int[_gridHeight, _gridWidth];
        for(int y = 0; y < tiles.GetLength(0); y++)
        {
            for(int x = 0; x < tiles.GetLength(1); x++)
            {
                if(y == 0)  // atas
                {
                    if(x == 0)  // kiri
                    {
                        tiles[y, x] = 6;
                    }
                    else if(x == _gridWidth - 1)    // kanan
                    {
                        tiles[y, x] = 8;
                    }
                    else    // tengah
                    {
                        tiles[y, x] = 7;
                    }
                }
                else if(y == _gridHeight - 1)   // bawah
                {
                    if(x == 0)  // kiri
                    {
                        tiles[y, x] = 1;
                    }
                    else if(x == _gridWidth - 1)   // kanan
                    {
                        tiles[y, x] = 3;
                    }
                    else    // tengah
                    {
                        tiles[y, x] = 2;
                    }
                }
                else    // tengah
                {
                    if(x == 0)  // kiri
                    {
                        tiles[y, x] = 4;
                    }
                    else if(x == _gridWidth - 1)    // kanan
                    {
                        tiles[y, x] = 5;
                    }
                    else    // tengah
                    {
                        tiles[y, x] = 9;
                    }
                }
            }
        }
        #endregion

        #region log
        string gridText = string.Empty;
        for(int y = 0; y < tiles.GetLength(0); y++)
        {
            for(int x = 0; x < tiles.GetLength(1); x++)
            {
                gridText += tiles[y, x] + " ";
            }
            gridText += "\n";
        }
        Debug.Log("Grid\n" + gridText);
        #endregion

        #region populate tiletypes
        List<string> availableTypes = new List<string>();
        availableTypes.Add(TileTypes[4]);
        availableTypes.Add(TileTypes[2]);
        availableTypes.Add(TileTypes[1]);
        for(int i = availableTypes.Count; i < tiles.GetLength(0) * tiles.GetLength(1); i++)
        {
            // if(Random.value < 0.1f)
            // {
            //     availableTypes.Add(TileTypes[1]);
            // }
            // else
            // {
                availableTypes.Add(TileTypes[3]);
            // }
        }
        Debug.Log(availableTypes.Count);
        #endregion

        #region spawn prefabs from resources
        GameObject root = new GameObject("Root");
        root.transform.SetParent(transform);

        string path = "Tilemaps/";
        for(int y = 0; y < tiles.GetLength(0); y++)
        {
            for(int x = 0; x < tiles.GetLength(1); x++)
            {
                int gridPosition = tiles[y, x];

                int typeIdx = Random.Range(0, availableTypes.Count);
                Debug.Log("idx " + typeIdx);
                string tileType = availableTypes[typeIdx];
                availableTypes.RemoveAt(typeIdx);
                Debug.Log("tile type " + tileType);
                Debug.Log(availableTypes.Count);

                GameObject[] availableMaps = Resources.LoadAll<GameObject>(path + gridPosition + "/" + tileType + "/");

                Vector3 pos = new Vector3(x * _tilemapWidth, y * -_tilemapHeight, y * -0.01f);
                GameObject randMap = availableMaps[Random.Range(0, availableMaps.Length)];

                GameObject spawnedMap = Instantiate(randMap, root.transform);
                spawnedMap.transform.localPosition = pos;

                LevelRoom room = spawnedMap.GetComponent<LevelRoom>();
                if(room == null)
                {
                    room = spawnedMap.AddComponent<LevelRoom>();
                    foreach(Transform child in spawnedMap.transform.GetChild(0))
                    {
                        if(child.gameObject.name.Contains("Food"))
                        {
                            room.FoodSpawnRoot = child;
                        }
                        else if(child.gameObject.name.Contains("Enemy"))
                        {
                            room.EnemySpawnRoot = child;
                        }
                        else if(child.gameObject.name.Contains("Ground") ||
                                child.gameObject.name.Contains("Object") ||
                                child.gameObject.name.Contains("PB"))
                        {
                            child.gameObject.AddComponent<TilemapCollider2D>();
                        }
                    }
                }
            }
        }
        #endregion
    }

    private void Cleanup()
    {
        if(transform.childCount > 0)
        {
            Destroy(transform.GetChild(0));
        }
    }
}
