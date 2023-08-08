using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleOnTriggerEnter : MonoBehaviour
{
    public ParticleSystem ripple;
    public LayerMask newLayer;
    public float rippleTime = 2.5f;
    private bool hasInstantiated = false;
    //public ParticleSystem newParticleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Horizontal Ground"))
        {
            SpawnParticleSystem(transform.position);
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Horizontal Ground"))
        {
            if(!hasInstantiated)
            {
                SpawnOneParticleSystem(transform.position);
                hasInstantiated = true;
            }

        }
    }*/

    private void OnTriggerExit(Collider other)
    {
        //print("Destroy PS");
        //Destroy(newParticleSystem.gameObject);
    }


        // Call this method to spawn the particle system at a specific position
    public void SpawnParticleSystem(Vector3 position)
    {
        // Ensure that the ParticleSystem prefab is not null
        if (ripple != null)
        {
            // Instantiate the particle system prefab at the given position
            ParticleSystem newParticleSystem = Instantiate(ripple, position, Quaternion.identity);

            // Optional: You can play the particle system immediately after instantiation
            newParticleSystem.gameObject.SetActive(true);
            newParticleSystem.Play();
            Destroy(newParticleSystem.gameObject,rippleTime);
        }
        else
        {
            Debug.LogWarning("Particle System Prefab is not assigned in the Inspector!");
        }
    }

            // Call this method to spawn the particle system at a specific position
    public void SpawnOneParticleSystem(Vector3 position)
    {
        // Ensure that the ParticleSystem prefab is not null
        if (ripple != null)
        {
            // Instantiate the particle system prefab at the given position
            ParticleSystem newParticleSystem = Instantiate(ripple, position, Quaternion.identity);

            // Optional: You can play the particle system immediately after instantiation
            newParticleSystem.gameObject.SetActive(true);
            newParticleSystem.Play();
            //Destroy(newParticleSystem.gameObject,rippleTime);
        }
        else
        {
            Debug.LogWarning("Particle System Prefab is not assigned in the Inspector!");
        }
    }


}
