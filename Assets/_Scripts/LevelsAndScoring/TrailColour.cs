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


    [SerializeField] Material[] materials; 


    void Start ()
    {
        aFloat = 1;
        materials = GetComponent<Renderer>().materials;

    }

    //booster wingtrail, wasn't noticed by children, so changed into green for cor answer and red for wrong answer
    /*public void ChangeTrailColour(int answerStreak)
    {

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
        materials[0].color = myColor;
        materials[1].color = myColor;
    }*/

    public void ChangeTrailCorrectColour()
    {
        rFloat = 0f;
        gFloat = 1f;
        bFloat = 0f;
        aFloat = 1;

        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        materials[0].color = myColor;
        materials[1].color = myColor;
    }

    public void ChangeTrailWrongColour()
    {

        rFloat = 1f;
        gFloat = 0f;
        bFloat = 0f;
        aFloat = 1;

        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        materials[0].color = myColor;
        materials[1].color = myColor;
    }
}

