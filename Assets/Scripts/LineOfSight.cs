using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    private LineRenderer lineRenderer;
    
    public Transform origin;
    public Transform destination;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer = SetPosition(0, origin.position);
        lineRenderer.SetWidth(.4f, .4f);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pointA = origin.position;
        Vector3 pointB = destination.position;

        lineRenderer.SetPosition(0, pointA);
        lineRenderer.SetPosition(1,pointB);
    }
}
