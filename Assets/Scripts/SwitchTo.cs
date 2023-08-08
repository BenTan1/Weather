using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTo : MonoBehaviour
{
    public MeshRenderer sphereMR;
    public MeshRenderer sphereMR1;
    public MeshRenderer sphereMR2;
    public MeshRenderer sphereMR3;
    public MeshRenderer sphereMR4;
    public MeshRenderer sphereMR5;


    public GameObject Rain;
    public GameObject Snow;
    public GameObject Wind;

    public Material ColourSwitch;
    public Material Default;

    // Start is called before the first frame update
    void Start()
    {
        sphereMR.material = Default;
    }

    public void ChangeSphere()
    {
        sphereMR.material = ColourSwitch;
        sphereMR1.material = Default;
        sphereMR2.material = Default;
        sphereMR3.material = Default;
        sphereMR4.material = Default;
        sphereMR5.material = Default;

        Rain.SetActive(true);
        Snow.SetActive(false);
        Wind.SetActive(false);
    }

    public void ChangeSphere1()
    {
        sphereMR1.material = ColourSwitch;

        sphereMR.material = Default;
        sphereMR2.material = Default;
        sphereMR3.material = Default;
        sphereMR4.material = Default;
        sphereMR5.material = Default;

        Snow.SetActive(true);
        Rain.SetActive(false);
        Wind.SetActive(false);
    }

    public void ChangeSphere2()
    {
        sphereMR2.material = ColourSwitch;

        sphereMR.material = Default;
        sphereMR1.material = Default;
        sphereMR3.material = Default;
        sphereMR4.material = Default;
        sphereMR5.material = Default;

        Wind.SetActive(true);
        Snow.SetActive(false);
        Rain.SetActive(false);
    }

    public void ChangeSphere3()
    {
        sphereMR3.material = ColourSwitch;

        sphereMR.material = Default;
        sphereMR2.material = Default;
        sphereMR1.material = Default;
        sphereMR4.material = Default;
        sphereMR5.material = Default;
        //Rain.SetActive(true);

        Wind.SetActive(false);
        Snow.SetActive(false);
        Rain.SetActive(false);
    }

    public void ChangeSphere4()
    {
        sphereMR4.material = ColourSwitch;

        sphereMR1.material = Default;
        sphereMR2.material = Default;
        sphereMR3.material = Default;
        sphereMR.material = Default;
        sphereMR5.material = Default;
        //Rain.SetActive(true);

        Wind.SetActive(false);
        Snow.SetActive(false);
        Rain.SetActive(false);
    }

    public void ChangeSphere5()
    {
        sphereMR5.material = ColourSwitch;

        sphereMR1.material = Default;
        sphereMR2.material = Default;
        sphereMR3.material = Default;
        sphereMR4.material = Default;
        sphereMR.material = Default;


        Wind.SetActive(false);
        Snow.SetActive(false);
        Rain.SetActive(false);
        //Rain.SetActive(true);
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
