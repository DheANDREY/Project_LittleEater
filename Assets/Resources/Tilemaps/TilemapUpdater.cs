// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEditor;

// public class TilemapUpdater : MonoBehaviour
// {
//     [MenuItem("LittleEater/UpdateTilemaps")]
//     public static void UpdateTilemaps()
//     {
//         string path = "Tilemaps/";
//         for(int i = 1; i <= 9; i++)
//         {
//             foreach(string type in LevelGenerator.TileTypes)
//             {
//                 path += i + "/" + type + "/";
//                 GameObject[] resourcePrefabs = Resources.LoadAll<GameObject>(path);
//                 foreach(GameObject prefab in resourcePrefabs)
//                 {
//                     path += prefab.name;
//                 }

//                 GameObject editPrefab = PrefabUtility.LoadPrefabContents(path);

//                 LevelRoom room = editPrefab.GetComponent<LevelRoom>();
//                 if(room == null)
//                 {
//                     PrefabUtility.LoadPrefabContents(path);
//                     room = editPrefab.AddComponent<LevelRoom>();
//                 }

//                 foreach(Transform child in editPrefab.transform.GetChild(0))
//                 {
//                     if(child.gameObject.name.Contains("Food"))
//                     {
//                         room.FoodSpawnRoot = child;
//                     }
//                     else if(child.gameObject.name.Contains("Enemy"))
//                     {
//                         room.EnemySpawnRoot = child;
//                     }
//                 }
//             }
//         }}
//     }
// }
