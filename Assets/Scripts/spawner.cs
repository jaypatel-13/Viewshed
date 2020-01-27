using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class spawner : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	
	public void createTower()
	{
			Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
			Thread.Sleep(100);
		
	}
}