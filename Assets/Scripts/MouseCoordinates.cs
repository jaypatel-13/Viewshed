using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseCoordinates : MonoBehaviour
{
    public Text etext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         etext.text = Camera.main.ScreenToViewportPoint(Input.mousePosition).ToString();
    }
}
