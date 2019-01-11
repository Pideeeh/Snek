using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spawns new Food Block whenever the last one was eaten
public class FoodSpawner : MonoBehaviour
{

	public GameObject FoodPrefab;

	private GameObject currentFood;
	
	void Update () {
		if (currentFood == null)
		{
			SpawnFood();
		}
	}

	private void SpawnFood()
	{
		var r = new System.Random();
		currentFood = Instantiate(FoodPrefab);
		currentFood.transform.position = new Vector3(r.Next(-40,40),1,r.Next(-40,40));
	}
}
