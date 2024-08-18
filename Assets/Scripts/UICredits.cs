using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICredits : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject pauseMainPanel;
    [SerializeField] private GameObject creditsPanel;
    
    [Header("Buttons")]
    [SerializeField] private Button backButton;
    
    private void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveListener(OnBackButtonClicked);
    }

    private void OnBackButtonClicked()
    {
        creditsPanel.SetActive(false);
        pauseMainPanel.SetActive(true);
    }
}
