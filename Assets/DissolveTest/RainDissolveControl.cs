using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDissolveControl : MonoBehaviour
{
    public Material mat2;
    public float startVal = 1f;
    //public float newVal2 = 1f;
    //public float dissolveSpeed = 3f;
    //public string dissolveFloatName;
    // Start is called before the first frame update
    void Start()
    {
        
        //newVal2 = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        mat2.SetFloat("a", startVal);
        //mat2.SetFloat("a", startVal);
        /*if(newVal2 > 0)
        {
            newVal2 -= 0.01f * Time.deltaTime * dissolveSpeed;
            mat2.SetFloat("a", newVal2);
        }
        else
        {
            newVal2 = 0;
        }
        
        mat2.SetFloat("a", newVal2);*/
    }
}
