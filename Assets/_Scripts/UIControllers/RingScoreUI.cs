using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RingScoreUI : MonoBehaviour
{
    public RectTransform m_parent;
    public Camera m_uiCamera;
    public RectTransform m_text;
    public Canvas m_canvas;

    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] TextMeshProUGUI m_textProUGUI;
    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;


    private void Update()
    {
        if (fadeIn)
        {
            myUIGroup.alpha = 1f;
            fadeIn = false;
        }
        if (fadeOut)
        {
            if (myUIGroup.alpha >= 0)
            {
                myUIGroup.alpha -= Time.deltaTime;
                if (myUIGroup.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }

    public void ShowRingScorePos(int score)
    {
        int currentScore = score;
        m_textProUGUI.color = Color.green;
        m_textProUGUI.text = currentScore.ToString();
        Vector2 anchoredPos;
        Vector3 planePos = GameObject.Find("Airplane_1354").transform.position;
        Vector3 planeCanvasPos = m_uiCamera.WorldToScreenPoint(planePos);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(m_parent, planeCanvasPos, m_canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null: m_uiCamera, out anchoredPos);
        m_text.anchoredPosition = anchoredPos;
        ShowUI();
        Invoke("HideUI", (float)0.5);
    }

    public void ShowRingScoreNeg(int score)
    {
        int currentScore = score;
        m_textProUGUI.color = Color.red;
        m_textProUGUI.text = currentScore.ToString();
        Vector2 anchoredPos;
        Vector3 planePos = GameObject.Find("Airplane_1354").transform.position;
        Vector3 planeCanvasPos = m_uiCamera.WorldToScreenPoint(planePos);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(m_parent, planeCanvasPos, m_canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : m_uiCamera, out anchoredPos);
        m_text.anchoredPosition = anchoredPos;
        ShowUI();
        Invoke("HideUI", (float)0.5);
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
