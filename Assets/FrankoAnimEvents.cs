using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrankoAnimEvents : MonoBehaviour
{
    public ParticleSystem smoke;
    public void Poof()
    {
        smoke.Play();
    }
}
