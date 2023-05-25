using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SocialPlatforms.Impl;

[System.Serializable]
public class ScoreEntry
{
    public TrailColour[] trailColour;
    RingScoreUI scoreUI;

    public GameObject WingTrail;
    public Equation equation;
    public int answer;
    public float accuracy;
    public int answerStreak;

    public ScoreEntry(Equation equation, int answer, float accuracy)
    {
        this.equation = equation;
        this.answer = answer;
        this.accuracy = accuracy;
    }

    public int GetAnswerStreak()
    {
        return answerStreak;
    }


    public int GetScore()
    {
        //you always get 10 points
        int score = 10;

        //get 10 points for correct answer
        if (equation.GetCorrectAnswer() == answer)
            {
                score += 10;

                GameObject[] wingtrail = GameObject.FindGameObjectsWithTag("WingTrail");
                trailColour = new TrailColour[wingtrail.Length];
                for (int i = 0; i < wingtrail.Length; ++i)
                    {
                        trailColour[i] = wingtrail[i].GetComponent<TrailColour>();
                        trailColour[i].ChangeTrailCorrectColour();
                    }

                SoundEffects soundEffects = GameObject.Find("AnswerEffects").GetComponent<SoundEffects>();
                soundEffects.correctSound();

                //score += Mathf.FloorToInt(accuracy * 10);
                scoreUI = GameObject.Find("RingScoreUIMover").GetComponent<RingScoreUI>();
                scoreUI.ShowRingScorePos(score);
        }
        else if (equation.GetCorrectAnswer() != answer)
        {
            GameObject[] wingtrail = GameObject.FindGameObjectsWithTag("WingTrail");
            trailColour = new TrailColour[wingtrail.Length];
            for (int i = 0; i < wingtrail.Length; ++i)
            {
                trailColour[i] = wingtrail[i].GetComponent<TrailColour>();
                trailColour[i].ChangeTrailWrongColour();
            }

            //score += Mathf.FloorToInt(accuracy * 10);
            scoreUI = GameObject.Find("RingScoreUIMover").GetComponent<RingScoreUI>();
            scoreUI.ShowRingScoreNeg(score);

            SoundEffects soundEffects = GameObject.Find("AnswerEffects").GetComponent<SoundEffects>();
            soundEffects.wrongSound();

        }

        //get 10 points for going through the ring
        //get 0 to 9 extra points for going through the ring other than the center
        //get 10 extra points for going through the center
        
        Debug.Log("this is the score " + score);


        return score;
    }
}
