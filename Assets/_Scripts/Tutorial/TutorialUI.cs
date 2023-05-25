using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour
{
    public TrailColour[] trailColour;

    public AudioSource correct;
    public AudioSource wrong;


    [SerializeField] private GameObject FlyLeft;
    [SerializeField] private GameObject FlyRight;
    [SerializeField] private GameObject FlyTop;
    [SerializeField] private GameObject FlyBottom;
    [SerializeField] private GameObject FlyTopRight;
    [SerializeField] private GameObject FlyBottomLeft;
    [SerializeField] private GameObject FlyTopLeft;
    [SerializeField] private GameObject FlyBottomRight;
    [SerializeField] private GameObject FlyTableOne;
    [SerializeField] private GameObject FlyTableTen;
    [SerializeField] private GameObject FlyTableFive;
    [SerializeField] private GameObject FlyEnd;

    [SerializeField] private CanvasGroup groupLeft;
    [SerializeField] private CanvasGroup groupRight;
    [SerializeField] private CanvasGroup groupTop;
    [SerializeField] private CanvasGroup groupBottom;
    [SerializeField] private CanvasGroup groupTopRight;
    [SerializeField] private CanvasGroup groupBottomLeft;
    [SerializeField] private CanvasGroup groupTopLeft;
    [SerializeField] private CanvasGroup groupBottomRight;
    [SerializeField] private CanvasGroup groupTableOne;
    [SerializeField] private CanvasGroup groupTableTen;
    [SerializeField] private CanvasGroup groupTableFive;
    [SerializeField] private CanvasGroup groupEndTutorial;

    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;
    private string group;

    private void Update()
    {
        if (group == "right")
        {
            if (fadeIn)
            {
                FlyRight.SetActive(true);
                groupRight.alpha = groupRight.alpha + (2 * Time.deltaTime) ;
                if (groupRight.alpha == 1)
                {
                    fadeIn = false;

                }
            }
            if (fadeOut)
            {
                if (groupLeft.alpha >= 0)
                {
                    groupLeft.alpha = groupLeft.alpha - (2* Time.deltaTime);
                    if (groupLeft.alpha == 0)
                    {
                        fadeOut = false;
                        FlyLeft.SetActive(false);

                    }
                }
            }
        }

        if (group == "top")
        {
            if (fadeIn)
            {
                FlyTop.SetActive(true);
                groupTop.alpha += 2*Time.deltaTime;
                if (groupTop.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupRight.alpha >= 0)
                {
                    groupRight.alpha -= 2*Time.deltaTime;
                    if (groupRight.alpha == 0)
                    {
                        fadeOut = false;
                        FlyRight.SetActive(false);
                    }
                }
            }
        }

        if (group == "bottom")
        {
            if (fadeIn)
            {
                FlyBottom.SetActive(true);
                groupBottom.alpha += 2*Time.deltaTime;
                if (groupBottom.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupTop.alpha >= 0)
                {
                    groupTop.alpha -= 2*Time.deltaTime;
                    if (groupTop.alpha == 0)
                    {
                        fadeOut = false;
                        FlyTop.SetActive(false) ;
                    }
                }
            }
        }

        if (group == "topRight")
        {
            if (fadeIn)
            {
                FlyTopRight.SetActive(true);
                groupTopRight.alpha += 2*Time.deltaTime;
                if (groupTopRight.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupBottom.alpha >= 0)
                {
                    groupBottom.alpha -= 2*Time.deltaTime;
                    if (groupBottom.alpha == 0)
                    {
                        fadeOut = false;
                        FlyBottom.SetActive(false) ;
                    }
                }
            }
        }

        if (group == "bottomLeft")
        {
            if (fadeIn)
            {
                FlyBottomLeft.SetActive(true);
                groupBottomLeft.alpha += 2*Time.deltaTime;
                if (groupBottomLeft.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupTopRight.alpha >= 0)
                {
                    groupTopRight.alpha -= 2*Time.deltaTime;
                    if (groupTopRight.alpha == 0)
                    {
                        fadeOut = false;
                        FlyTopRight.SetActive(false);
                    }
                }
            }
        }

        if (group == "topLeft")
        {
            if (fadeIn)
            {
                FlyTopLeft.SetActive(true);
                groupTopLeft.alpha += 2*Time.deltaTime;
                if (groupTopLeft.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupBottomLeft.alpha >= 0)
                {
                    groupBottomLeft.alpha -= 2*Time.deltaTime;
                    if (groupBottomLeft.alpha == 0)
                    {
                        fadeOut = false;
                        FlyBottomLeft.SetActive(false);
                    }
                }
            }
        }

        if (group == "bottomRight")
        {
            if (fadeIn)
            {
                FlyBottomRight.SetActive(true);
                groupBottomRight.alpha += 2*Time.deltaTime;
                if (groupBottomRight.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupTopLeft.alpha >= 0)
                {
                    groupTopLeft.alpha -= 2*Time.deltaTime;
                    if (groupTopLeft.alpha == 0)
                    {
                        fadeOut = false;
                        FlyTopLeft.SetActive(false) ;
                    }
                }
            }
        }

        if (group == "tableOne")
        {
            if (fadeIn)
            {
                FlyTableOne.SetActive(true);
                groupTableOne.alpha += 2 * Time.deltaTime;
                if (groupTableOne.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupBottomRight.alpha >= 0)
                {
                    groupBottomRight.alpha -= 2 * Time.deltaTime;
                    if (groupBottomRight.alpha == 0)
                    {
                        fadeOut = false;
                        FlyBottomRight.SetActive(false);
                    }
                }
            }
        }

        if (group == "tableTen")
        {
            if (fadeIn)
            {
                FlyTableTen.SetActive(true);
                groupTableTen.alpha += 2 * Time.deltaTime;
                if (groupTableTen.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupTableOne.alpha >= 0)
                {
                    groupTableOne.alpha -= 2 * Time.deltaTime;
                    if (groupTableOne.alpha == 0)
                    {
                        fadeOut = false;
                        FlyTableOne.SetActive(false);
                    }
                }
            }
        }

        if (group == "tableFive")
        {
            if (fadeIn)
            {
                FlyTableFive.SetActive(true);
                groupTableFive.alpha += 2 * Time.deltaTime;
                if (groupTableFive.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupTableTen.alpha >= 0)
                {
                    groupTableTen.alpha -= 2 * Time.deltaTime;
                    if (groupTableTen.alpha == 0)
                    {
                        fadeOut = false;
                        FlyTableTen.SetActive(false);
                    }
                }
            }
        }


        if (group == "endTutorial")
        {
            if (fadeIn)
            {
                FlyEnd.SetActive(true);
                groupEndTutorial.alpha += 2*Time.deltaTime;
                if (groupEndTutorial.alpha == 1)
                {
                    fadeIn = false;
                }
            }
            if (fadeOut)
            {
                if (groupTableFive.alpha >= 0)
                {
                    groupTableFive.alpha -= 2*Time.deltaTime;
                    if (groupTableFive.alpha == 0)
                    {
                        fadeOut = false;
                        FlyTableFive.SetActive(false) ;
                    }
                }
            }
        }
    }

    public void wrongAnswer()
    {
        wrong.Play();
        GameObject[] wingtrail = GameObject.FindGameObjectsWithTag("WingTrail");
        trailColour = new TrailColour[wingtrail.Length];
        for (int i = 0; i < wingtrail.Length; ++i)
        {
            trailColour[i] = wingtrail[i].GetComponent<TrailColour>();
            trailColour[i].ChangeTrailWrongColour();
        }
    }

    public void correctAnswer()
    {
        GameObject[] wingtrail = GameObject.FindGameObjectsWithTag("WingTrail");
        trailColour = new TrailColour[wingtrail.Length];
        for (int i = 0; i < wingtrail.Length; ++i)
        {
            trailColour[i] = wingtrail[i].GetComponent<TrailColour>();
            trailColour[i].ChangeTrailCorrectColour();
        }
    }
    
    public void flyLeft()
    {
        group = "right";
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyRight()
    {
        group = "top";
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyTop()
    {
        group = "bottom";
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyBottom()
    {
        group = "topRight";
        correct.Play();
        HideUI();
        ShowUI();
    }

    public void flyTopRight()
    {
        group = "bottomLeft";
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyBottomLeft()
    {
        group = "topLeft";
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyTopLeft()
    {
        group = "bottomRight";
        correct.Play();
        HideUI();
        ShowUI();

    }
    public void flyBottomRight()
    {
        group = "tableOne";
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyTableOne()
    {
        group = "tableTen";
        correct.Play();
        correctAnswer();
        HideUI();
        ShowUI();

    }

    public void flyTableTen()
    {
        group = "tableFive";
        correct.Play();
        correctAnswer();
        HideUI();
        ShowUI();
    }

    public void flyTableFive()
    {
        group = "endTutorial";
        correct.Play();
        correctAnswer();
        HideUI();
        ShowUI();

    }

    public void ShowUI()
    {
        fadeIn = true;
    }

    public void HideUI()
    {
        fadeOut = true;
    }
}
