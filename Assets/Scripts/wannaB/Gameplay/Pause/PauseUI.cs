using UnityEngine;

namespace wannaB.Gameplay.Pause
{
public class PauseUI : MonoBehaviour
{
    private void Start()
    {
        GameManager.Pause.onGamePauseStatusChanged.AddListener(HandleGamePauseStatusChanged);
    }

    private void OnDisable()
    {
        GameManager.Pause.onGamePauseStatusChanged.RemoveListener(HandleGamePauseStatusChanged);
    }

    private void HandleGamePauseStatusChanged(bool isPaused)
    {
        this.gameObject.SetActive(isPaused);
    }
}
}
