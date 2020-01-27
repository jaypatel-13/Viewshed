using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    private bool change = false;
    private Light[] lights;
    public Light directionalLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(change)
        {
            lights = FindObjectsOfType(typeof(Light)) as Light[];

            foreach (Light l in lights)
            {
                l.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            }
            directionalLight.color = new Color(1.0f,0.9822f,0.8349f,1.0f); //FFFAD5;
            change = false;
        }
    }

    public void ChangeColour()
    {
        change = true;
    }
}