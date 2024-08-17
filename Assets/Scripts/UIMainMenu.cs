using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject pauseMainPanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    
    [Header("Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
        
        pauseMainPanel.SetActive(true);
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveListener(OnPlayButtonClicked);
        settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        creditsButton.onClick.RemoveListener(OnCreditsButtonClicked);
    }
    
    private void OnPlayButtonClicked()
    {
        GameManager.IsGamePaused = false;
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    
    private void OnSettingsButtonClicked()
    {
        pauseMainPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }
    
    private void OnCreditsButtonClicked()
    {
        pauseMainPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }
    
    private static void OnExitButtonClicked()
    { 
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        
        Application.Quit();
    }
}
