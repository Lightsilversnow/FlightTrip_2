using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailColour : MonoBehaviour
{
    public Color myColor;
    public float rFloat;
    public float gFloat;
    public float bFloat;
    public float aFloat;
    //0 to 1

    public ParticleSystem myparticleSystem;
    public Material myMaterial;
    public Renderer myRenderer;


    void Start ()
    {
        aFloat = 1;
        myparticleSystem = GetComponent<ParticleSystem>();
        myMaterial = GetComponent<Material>();
        myRenderer = GetComponent<Renderer>();

    }

    public void ChangeTrailColour(int answerStreak)
    {
        var main = myparticleSystem.main;

        if (answerStreak == 0)
        {
            rFloat = 1f;
            gFloat = 1f;
            bFloat = 1f;
            aFloat = 1f;
        }
        if (answerStreak == 1)
        {
            rFloat = 0.98f;
            gFloat = 0.99f;
            bFloat = 0.73f;
            aFloat = 1;
        }
        if (answerStreak == 2)
        {
            rFloat = 0.99f;
            gFloat = 0.91f;
            bFloat = 0.73f;
            aFloat = 1;
        }
        if (answerStreak == 3)
        {
            rFloat = 0.96f;
            gFloat = 0.74f;
            bFloat = 0.25f;
            aFloat = 1;
        }
        if (answerStreak == 4)
        {
            rFloat = 0.96f;
            gFloat = 0.54f;
            bFloat = 0.25f;
            aFloat = 1;
        }
        if (answerStreak == 5)
        {
            rFloat = 0.96f;
            gFloat = 0.34f;
            bFloat = 0.25f;
            aFloat = 1;
        }

        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        main.startColor= myColor;
        myMaterial.color= myColor;
        myRenderer.material.color = myColor;


    }
}

