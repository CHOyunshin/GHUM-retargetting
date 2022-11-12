using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class LineCode : MonoBehaviour
{

    LineRenderer lineRenderer;

    public Transform origin;
    public Transform destination; // attach 자동으로 생김 -> line venderer

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, destination.position);
    }
}
