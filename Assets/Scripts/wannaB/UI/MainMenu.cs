using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace wannaB.UI
{
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject settingsPanel;

    private void Awake()
    {
        HideAllPanels();
        mainMenuPanel.SetActive(true);
    }

    public void UI_OnPlayGameClicked()
    {
        if (SceneManager.sceneCount > 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void UI_OnSettingsClicked()
    {
        HideAllPanels();
        settingsPanel.SetActive(true);
    }

    public void UI_OnExitClicked()
    {
        Application.Quit();
    }

    public void UI_OnBackToMainMenuClicked()
    {
        HideAllPanels();
        mainMenuPanel.SetActive(true);
    }

    private void HideAllPanels()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }
}
}
