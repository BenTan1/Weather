using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainParticleEmissionController : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private ParticleSystem.EmissionModule emissionModule;

    public float defaultEmissionRate = 50f;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();

        emissionModule = particleSystem.emission;

        SetEmissionRate(defaultEmissionRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetEmissionRate(float rate)
    {
        ParticleSystem.MinMaxCurve emissionRateCurve = new ParticleSystem.MinMaxCurve(rate);
        emissionModule.rateOverTime = emissionRateCurve;
    }
}
