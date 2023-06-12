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
    public GameObject oldGameObject;
    public CanvasGroup oldCanvasGroup;
    public GameObject newGameObject;
    public CanvasGroup newCanvasGroup;


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

        if (fadeIn)
        {
            newGameObject.SetActive(true);
            newCanvasGroup.alpha = newCanvasGroup.alpha + (2 * Time.deltaTime);
            if (newCanvasGroup.alpha == 1)
            {
                fadeIn = false;

            }
        }
        if (fadeOut)
        {
            if (oldCanvasGroup.alpha >= 0)
            {
                oldCanvasGroup.alpha = oldCanvasGroup.alpha - (2 * Time.deltaTime);
                if (oldCanvasGroup.alpha == 0)
                {
                    fadeOut = false;
                    oldGameObject.SetActive(false);

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
        oldGameObject = FlyLeft;
        oldCanvasGroup = groupLeft;
        newGameObject = FlyRight;
        newCanvasGroup = groupRight;
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyRight()
    {
        oldGameObject = FlyRight;
        oldCanvasGroup = groupRight;
        newGameObject = FlyTop;
        newCanvasGroup = groupTop;
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyTop()
    {
        oldGameObject = FlyTop;
        oldCanvasGroup = groupTop;
        newGameObject = FlyBottom;
        newCanvasGroup = groupBottom;
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyBottom()
    {
        oldGameObject = FlyBottom;
        oldCanvasGroup = groupBottom;
        newGameObject = FlyTopRight;
        newCanvasGroup = groupTopRight;
        correct.Play();
        HideUI();
        ShowUI();
    }

    public void flyTopRight()
    {
        oldGameObject = FlyTopRight;
        oldCanvasGroup = groupTopRight;
        newGameObject = FlyBottomLeft;
        newCanvasGroup = groupBottomLeft;
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyBottomLeft()
    {
        oldGameObject = FlyBottomLeft;
        oldCanvasGroup = groupBottomLeft;
        newGameObject = FlyTopLeft;
        newCanvasGroup = groupTopLeft;
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyTopLeft()
    {
        oldGameObject = FlyTopLeft;
        oldCanvasGroup = groupTopLeft;
        newGameObject = FlyBottomRight;
        newCanvasGroup = groupBottomRight;
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyBottomRight()
    {
        oldGameObject = FlyBottomRight;
        oldCanvasGroup = groupBottomRight;
        newGameObject = FlyTableOne;
        newCanvasGroup = groupTableOne;
        correct.Play();
        HideUI();
        ShowUI();

    }

    public void flyTableOne()
    {
        oldGameObject = FlyTableOne;
        oldCanvasGroup = groupTableOne;
        newGameObject = FlyTableTen;
        newCanvasGroup = groupTableTen;
        correct.Play();
        correctAnswer();
        HideUI();
        ShowUI();

    }

    public void flyTableTen()
    {
        oldGameObject = FlyTableTen;
        oldCanvasGroup = groupTableTen;
        newGameObject = FlyTableFive;
        newCanvasGroup = groupTableFive;
        correct.Play();
        correctAnswer();
        HideUI();
        ShowUI();
    }

    public void flyTableFive()
    {
        oldGameObject = FlyTableFive;
        oldCanvasGroup = groupTableFive;
        newGameObject = FlyEnd;
        newCanvasGroup = groupEndTutorial;
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
