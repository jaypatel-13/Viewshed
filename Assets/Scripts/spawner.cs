using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class spawner : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	public Canvas canvas;
	private Text text;
	private GameObject textGo;
	private bool change = false;
	public void createTower()
	{
			Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
			Thread.Sleep(100);
			change = true;
			textGo = new GameObject();
			textGo.transform.parent = canvas.transform;
			textGo.AddComponent<Text>();
		
	}

	void Update()
	{
		if(change)
		{

		text = textGo.GetComponent<Text>();
		//text.font = arial;
		text.text = (spawnPos.transform.position).ToString();
		text.fontSize = 12;
	//text.alignment = TextAnchor.TopLeft;
		
		RectTransform rectTransform;
       	rectTransform = text.GetComponent<RectTransform>();
       	rectTransform.localPosition = new Vector3(0, 0, 0);
       	rectTransform.sizeDelta = new Vector2(600, 200);
		
		}
	}
}