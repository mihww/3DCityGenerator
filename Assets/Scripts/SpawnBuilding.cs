using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuilding : MonoBehaviour
{
    public GameObject[] buildings;

	private void Start()
	{
		Instantiate(buildings[Random.Range(0, buildings.Length)], transform.position, Quaternion.identity);
	}
}
