using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISettings : MonoBehaviour
{
    private Movement _player1Movement;
    private Movement _player2Movement;
    
    [Header("Panels")]
    [SerializeField] private GameObject pausePanel;
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

    private void OnBackButtonClicked()
    {
        settingsPanel.SetActive(false);
        pausePanel.SetActive(true);
        Debug.Log("OnBackButtonClicked");
    }
    
    private void OnSliderPlayer1SpeedChange(float speed)
    {
        _player1Movement.SetMovementSpeed(speed);
        sliderPlayer1SpeedText.text = speed.ToString(CultureInfo.InvariantCulture);
    }
    
    private void OnSliderPlayer2SpeedChange(float speed)
    {
        _player2Movement.SetMovementSpeed(speed);
        sliderPlayer2SpeedText.text = speed.ToString(CultureInfo.InvariantCulture);
    }
}
