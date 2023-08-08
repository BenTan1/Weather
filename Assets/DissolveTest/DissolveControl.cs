using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveControl : MonoBehaviour
{
    public Material mat;
    public float startVal = 1f;
    public float newVal = 1f;
    public float dissolveSpeed = 3f;
    public string dissolveFloatName;
    // Start is called before the first frame update
    void Start()
    {
        //mat.SetFloat(dissolveFloatName, startVal);
        newVal = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat(dissolveFloatName, startVal*5);
        if(newVal > 0)
        {
            newVal -= 0.01f * Time.deltaTime * dissolveSpeed;
        }
        else
        {
            newVal = 0;
        }
        
        mat.SetFloat(dissolveFloatName,newVal);
    }
}
