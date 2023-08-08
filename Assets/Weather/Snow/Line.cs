using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer line;
    public Transform pos2;
    public Material lineMaterial;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.material = lineMaterial;
        
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0,pos.position);
        line.SetPosition(1,pos2.position);
    }
}
