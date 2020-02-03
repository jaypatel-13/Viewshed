using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class spawner : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	public void createTower()
	{
			Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
			Thread.Sleep(100);
		
	}

}