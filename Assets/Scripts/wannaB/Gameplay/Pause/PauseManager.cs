using UnityEngine;
using UnityEngine.Events;

namespace wannaB.Gameplay.Pause
{
public class PauseManager : MonoBehaviour
{
    [HideInInspector] public UnityEvent<bool> onGamePauseStatusChanged;

    private float _originalTimeScale = 1f;

    private void Awake()
    {
        this._originalTimeScale = Time.timeScale;
    }

    public void PauseGame()
    {
        this._originalTimeScale = Time.timeScale;
        Time.timeScale = 0f;
        onGamePauseStatusChanged?.Invoke(true);
    }

    public void UnpauseGame()
    {
        Time.timeScale = this._originalTimeScale;
        onGamePauseStatusChanged?.Invoke(false);
    }
}
}
