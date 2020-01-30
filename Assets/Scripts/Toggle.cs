using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ToggleDestroyer : MonoBehaviour
{
	
	public GameObject spawnee;
	
    void Start()
    {
        ToggleRemover(PlayerPrefs.GetInt("Counter"));
    }
	public void remover()
    {
	 	changeCounter();
    }
	void changeCounter()
	{
		int counter = PlayerPrefs.GetInt("Counter");
		counter++;
		ToggleRemover(counter);
	}

	void ToggleRemover(int counter)
	{
		if(counter > 1)
		{
			counter=0;
		}

        PlayerPrefs.SetInt("Counter",counter);
		
		if(counter == 0)
		{
			spawnee.SetActive(true);
		}
		
		if(counter == 1)
		{
			spawnee.SetActive(false);
		}	
	}
}
