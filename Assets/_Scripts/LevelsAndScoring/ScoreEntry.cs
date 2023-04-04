using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SocialPlatforms.Impl;

[System.Serializable]
public class ScoreEntry
{
    TrailColour trailColour;
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
                if (answerStreak <5)
                {
                    answerStreak++;
                    trailColour = GameObject.Find("WingTrail").GetComponent<TrailColour>();
                    trailColour.ChangeTrailColour(answerStreak);
                trailColour.ChangeTrailColour(answerStreak);
                trailColour.ChangeTrailColour(answerStreak);
                trailColour.ChangeTrailColour(answerStreak);

                score += Mathf.FloorToInt(accuracy * 10);
                    scoreUI = GameObject.Find("RingScoreUIMover").GetComponent<RingScoreUI>();
                    scoreUI.ShowRingScorePos(score);
            }
            }
        else if (equation.GetCorrectAnswer() != answer)
        {
            answerStreak = 0;
            trailColour = GameObject.Find("WingTrail").GetComponent<TrailColour>();
            trailColour.ChangeTrailColour(answerStreak);
            score += Mathf.FloorToInt(accuracy * 10);
            scoreUI = GameObject.Find("RingScoreUIMover").GetComponent<RingScoreUI>();
            scoreUI.ShowRingScoreNeg(score);

        }

        //get 10 points for going through the ring
        //get 0 to 9 extra points for going through the ring other than the center
        //get 10 extra points for going through the center
        
        Debug.Log("this is the score " + score);


        return score;
    }
}
