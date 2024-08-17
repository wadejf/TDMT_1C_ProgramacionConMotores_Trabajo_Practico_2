using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    
    [Header("Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;

    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveListener(OnPlayButtonClicked);
        settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        creditsButton.onClick.RemoveListener(OnCreditsButtonClicked);
    }
    
    private void OnPlayButtonClicked()
    {
        pausePanel.SetActive(false);
        Debug.Log("OnPlayButtonClicked");
    }
    
    private void OnSettingsButtonClicked()
    {
        settingsPanel.SetActive(true);
        Debug.Log("OnSettingsButtonClicked");
    }
    
    private void OnCreditsButtonClicked()
    {
        creditsPanel.SetActive(true);
        Debug.Log("OnCreditsButtonClicked");
    }
}
