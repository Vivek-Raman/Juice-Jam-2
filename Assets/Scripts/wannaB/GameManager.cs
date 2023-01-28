using UnityEngine;
using wannaB.Audio;
using wannaB.Camera;
using wannaB.Gameplay.Pause;
using wannaB.Gameplay.Player;
using wannaB.Settings;
using wannaB.Utility;

namespace wannaB
{
[RequireComponent(typeof(SettingsManager))]
[RequireComponent(typeof(AudioManager))]
[RequireComponent(typeof(CameraManager))]
[RequireComponent(typeof(PauseManager))]
[RequireComponent(typeof(PlayerManager))]
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    private SettingsManager _settingsManager;
    private AudioManager _audioManager;
    private CameraManager _cameraManager;
    private PauseManager _pauseManager;
    private PlayerManager _playerManager;

    #region Public Getters

    public static SettingsManager Settings => Instance._settingsManager;
    public static AudioManager Audio => Instance._audioManager;
    public static CameraManager Camera => Instance._cameraManager;
    public static PauseManager Pause => Instance._pauseManager;
    public static PlayerManager Player => Instance._playerManager;

    #endregion

    protected override void Awake()
    {
        base.Awake();

        InitializeSettings();
        InitializeAudio();
        InitializeCamera();
        InitializePause();
        InitializePlayer();
    }

    #region Initialize Methods

    private void InitializeSettings()
    {
        _settingsManager = this.GetComponent<SettingsManager>();
        _settingsManager.TrySaveFirstLaunchSettings();
        _settingsManager.LoadSettings();
    }

    private void InitializeAudio()
    {
        _audioManager = this.GetComponent<AudioManager>();
    }

    private void InitializeCamera()
    {
        _cameraManager = this.GetComponent<CameraManager>();
    }

    private void InitializePause()
    {
        _pauseManager = this.GetComponent<PauseManager>();
        _pauseManager.UnpauseGame();
    }

    private void InitializePlayer()
    {
        _playerManager = this.GetComponent<PlayerManager>();
    }

    #endregion Initialize Methods
}
}
