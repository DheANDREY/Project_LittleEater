using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRoom : MonoBehaviour
{
	[SerializeField] private Transform _foodSpawnRoot;
	[SerializeField] private Transform _enemySpawnRoot;

    private void Awake()
    {
    	if(_foodSpawnRoot != null)
    	{
    		SpawnFood();
    	}

    	if(_enemySpawnRoot != null)
    	{
    		SpawnEnemy();
    	}
    }

    private void SpawnFood()
    {
		GameObject[] foodPrefabs = Resources.LoadAll<GameObject>("Foods/");

    	foreach(Transform child in _foodSpawnRoot)
    	{
    		if(child.childCount == 0)
    		{
				GameObject prefab = foodPrefabs[Random.Range(0, foodPrefabs.Length)];
				GameObject food = Instantiate(prefab, child);
				food.transform.localPosition = Vector3.zero;
    		}
			Debug.Log("spawn food");
    	}
    }

    private void SpawnEnemy()
    {

    }
}
