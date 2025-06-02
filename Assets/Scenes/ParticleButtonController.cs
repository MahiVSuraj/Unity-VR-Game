using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleButtonController : MonoBehaviour
{
     public ParticleSystem particle;
    public void PlayParticleSystem()
    {
        if(particle != null)
        {
            particle.Play();
        }
    }
}
