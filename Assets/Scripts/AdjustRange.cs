using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustRange : MonoBehaviour
{
    private Light[] lights;
    public InputField inputRange;
    private bool change = false;

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

            float range;

            if(inputRange.text.Length == 0)
            {
                range = 200;
            }
            else
            {
                range = float.Parse(inputRange.text);
            }

            foreach (Light l in lights)
            {
                l.range = range;
            }
            change = false;
        }
    }

    public void changeRange()
    {
        change = true;
    }
}
