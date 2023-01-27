using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace wannaB.Settings
{
public class SettingsManager : MonoBehaviour
{

    private List<SettingItem> _settings;
    private string _settingsPrefix;

    public Dictionary<SettingKey, SettingItem> Settings => _settings.ToDictionary(item => item.SettingKey);

    private void Awake()
    {
        _settings = new List<SettingItem>(this.GetComponentsInChildren<SettingItem>());
        _settingsPrefix = PlayerSettings.companyName + "." + PlayerSettings.productName + ".Settings";
    }

    public void SaveSettings()
    {
        foreach (SettingItem item in _settings)
        {
            PlayerPrefs.SetString(GetPrefsKey(item.SettingKey), item.SettingValue);
        }

        PlayerPrefs.Save();
    }

    public void LoadSettings()
    {
        foreach (SettingItem item in _settings)
        {
            string newValue = PlayerPrefs.GetString(GetPrefsKey(item.SettingKey), item.SettingDefaultValue);
            item.LoadSettingValue(newValue);
        }
    }

    public void TrySaveFirstLaunchSettings()
    {
        if (bool.Parse(PlayerPrefs.GetString(GetPrefsKey(SettingKey.ReturningPlayer), "false"))) return;
        foreach (SettingItem item in _settings)
        {
            PlayerPrefs.SetString(GetPrefsKey(item.SettingKey), item.SettingDefaultValue);
        }

        PlayerPrefs.SetString(GetPrefsKey(SettingKey.ReturningPlayer), "true");
        PlayerPrefs.Save();
    }

    private string GetPrefsKey(SettingKey key) => _settingsPrefix + "." + key.ToString();
}
}
