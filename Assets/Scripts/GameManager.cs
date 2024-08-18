using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool IsGamePaused;
    
    [SerializeField] private KeyCode pauseKey;
    [SerializeField] private GameObject panelPause;
    [SerializeField] private GameObject panelPauseMain;
    [SerializeField] private GameObject panelPauseSettings;
    [SerializeField] private GameObject panelPauseCredits;

    private void Update()
    {
        if (Input.GetKeyDown(pauseKey)) 
        {
            HandleGamePause();
        }
    }

    private void HandleGamePause()
    {
        IsGamePaused = !IsGamePaused;
        Time.timeScale = IsGamePaused ? 0f : 1f;
        
        panelPause.SetActive(IsGamePaused);
        panelPauseMain.SetActive(IsGamePaused);
        panelPauseSettings.SetActive(false);
        panelPauseCredits.SetActive(false);
    }
}
