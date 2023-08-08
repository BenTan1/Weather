using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWeather : MonoBehaviour
{

    [Header ("Rain")]

    public bool toggleRain;
    //public GameObject rainGround;
    public GameObject rainParent;
    //public RainParticleEmissionController rainEmissionController;
    //public float rainSpeed;
    //public float puddleAmount;
    //public ControlPuddles controlPuddle;


    [Header ("Snow")]

    public bool toggleSnow;
    //public GameObject snowGround;
    public GameObject snowParent;
    //public SnowParticleEmissionController snowEmissionController;
    //public float snowSpeed;
    //public float snowAmount;
    //public ControlSnow controlSnow;

    [Header ("Sun")]
    public bool toggleSun;
    //public Material sunSkyboxMaterial;

    [Header ("Wind")]
    public bool toggleWind;
    public GameObject windGround;






    // Start is called before the first frame update
    void Start()
    {
        //rainSpeed = 200f;
        //snowSpeed = 100f;
        //puddleAmount = 1f;
        //snowAmount = 1f;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(toggleRain == true)
        {
            
            rainParent.SetActive(true);
            //rainGround.SetActive(true);
            //rainEmissionController.SetEmissionRate(rainSpeed);
            //controlPuddle.DissolveControl(puddleAmount);


        }

        else
        {
            rainParent.SetActive(false);
            //rainGround.SetActive(false);            
        }

        if(toggleSnow == true)
        {
            snowParent.SetActive(true);
            //snowGround.SetActive(true);            
            //snowEmissionController.SetEmissionRate(snowSpeed);
            //controlSnow.SnowDissolveControl(snowAmount);


        }

        else
        {
            snowParent.SetActive(false);
            //snowGround.SetActive(false);
        }

        if(toggleSun == true)
        {
            rainParent.SetActive(false);
            //rainGround.SetActive(false);
            snowParent.SetActive(false);
            //snowGround.SetActive(false);
            windGround.SetActive(false);
        }


        if(toggleWind == true)
        {
            windGround.SetActive(true);
        }

        else
        {
            windGround.SetActive(false);
        }

    }
}
