using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISettings : MonoBehaviour
{
    [Header("PlayersMovements")]
    [SerializeField] private Movement player1Movement;
    [SerializeField] private Movement player2Movement;
    
    [Header("Panels")]
    [SerializeField] private GameObject pauseMainPanel;
    [SerializeField] private GameObject settingsPanel;
    
    [Header("Buttons")]
    [SerializeField] private Button backButton;

    [Header("Sliders")]
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;
    
    [Header("SliderTexts")]
    [SerializeField] private TextMeshProUGUI sliderPlayer1SpeedText;
    [SerializeField] private TextMeshProUGUI sliderPlayer2SpeedText;
    
    private void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
        sliderPlayer1Speed.onValueChanged.AddListener(OnSliderPlayer1SpeedChange);
        sliderPlayer2Speed.onValueChanged.AddListener(OnSliderPlayer2SpeedChange);
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveListener(OnBackButtonClicked);
        sliderPlayer1Speed.onValueChanged.RemoveListener(OnSliderPlayer1SpeedChange);
        sliderPlayer2Speed.onValueChanged.RemoveListener(OnSliderPlayer2SpeedChange);
    }
    
    private void OnSliderPlayer1SpeedChange(float speed)
    {
        player1Movement.SetMovementSpeed(speed);
        sliderPlayer1SpeedText.text = speed.ToString(CultureInfo.InvariantCulture);
    }
    
    private void OnSliderPlayer2SpeedChange(float speed)
    {
        player2Movement.SetMovementSpeed(speed);
        sliderPlayer2SpeedText.text = speed.ToString(CultureInfo.InvariantCulture);
    }

    private void OnBackButtonClicked()
    {
        settingsPanel.SetActive(false);
        pauseMainPanel.SetActive(true);
        Debug.Log("OnBackButtonClicked");
    }
}
