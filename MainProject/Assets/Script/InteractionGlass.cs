﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class InteractionGlass : MonoBehaviour
{

    private GameObject glassObject;
    private GameObject particles;
    public static bool filled = false;
    void Start()
    {
        glassObject = GameObject.Find("Final_glass_water");
        particles = GameObject.Find("Particle_holder");
}
    public void fillGlass()
    {
        if (!filled)
        {
            glassObject.GetComponent<Animator>().SetBool("Glass_fill", true);
            filled = true;
        }
        particles.GetComponent<ParticleSystem>().Clear();
        particles.GetComponent<ParticleSystem>().Play();
    }

    public void emptyGlass()
    {
        glassObject.GetComponent<Animator>().SetBool("Glass_fill", false);
        filled = false;
        particles.GetComponent<ParticleSystem>().Stop();
    }


}