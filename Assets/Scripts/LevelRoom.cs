using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRoom : MonoBehaviour
{
	public Transform FoodSpawnRoot;
	public Transform EnemySpawnRoot;

    private void Start()
    {
    	if(FoodSpawnRoot != null)
    	{
    		SpawnFood();
    	}

    	if(EnemySpawnRoot != null)
    	{
    		SpawnEnemy();
    	}
    }

    private void SpawnFood()
    {
		GameObject[] foodPrefabs = Resources.LoadAll<GameObject>("Foods/");
		
    	foreach(Transform child in FoodSpawnRoot)
    	{
    		if(child.childCount == 0)
    		{
				GameObject prefab = foodPrefabs[Random.Range(0, foodPrefabs.Length)];
				GameObject food = Instantiate(prefab, child);
				food.transform.localPosition = Vector3.zero;
    		}
    	}
    }

    private void SpawnEnemy()
    {
		GameObject[] enemyPrefabs = Resources.LoadAll<GameObject>("Enemies/");

    	foreach(Transform child in EnemySpawnRoot)
    	{
    		if(child.childCount == 0)
    		{
				GameObject prefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
				GameObject food = Instantiate(prefab, child);
				food.transform.localPosition = Vector3.zero;
    		}
    	}
    }
}
