using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool IsGamePaused;
    
    [SerializeField] private KeyCode pauseKey;
    [SerializeField] private GameObject pausePanel;
    

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
        Time.timeScale = IsGamePaused ? 0 : 1;
        pausePanel.SetActive(IsGamePaused);
    }
}
