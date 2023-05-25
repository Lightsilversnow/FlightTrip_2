using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;
using System;

public class TutorialScreenController : MonoBehaviour, IDataPersistence
{
    [Header("Player")]
    [SerializeField]
    Player player;

    [Header("Game State")]
    [SerializeField]
    bool gameHasEnded = false;
    [SerializeField]
    CinemachineSmoothPath currentTrack;

    [Header("Set Up")]
    [SerializeField]
    CinemachineDollyCart dollyCart;
    [SerializeField]
    List<CinemachineSmoothPath> tracks;
    [SerializeField]
    Dictionary<CinemachineSmoothPath, List<EquationPoint>> equationPoints;
    [SerializeField]
    Session session;

    [Header("Events")]
    [SerializeField]
    UnityEvent gameEnded;

    private void Start()
    {
        equationPoints = new Dictionary<CinemachineSmoothPath, List<EquationPoint>>();
        SwitchTrack(tracks[0]);
    }
    private void Update()
    {

    }
    private void SwitchTrack(CinemachineSmoothPath track)
    {
        currentTrack = track;
    }
    
    public void EndGame()
    {
        dollyCart.m_Speed = 0;
        player.AddSessionData(session);
        gameEnded.Invoke();
    }

    public void LoadData(GameData gameData)
    {
        player.SetPlayerData(gameData);
        session = gameData.latestSession;
    }

    public void SaveData(GameData gameData)
    {
        gameData.playerData = player.GetPlayerData();
    }
}
