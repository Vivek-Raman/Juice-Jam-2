using UnityEngine;
using UnityEngine.Events;

namespace wannaB.Settings
{
public class SettingItem : MonoBehaviour
{
    [SerializeField] protected UnityEvent<string> onSettingValueChanged;

    [SerializeField] private SettingKey settingKey;
    [SerializeField] private string settingDefaultValue;
    private string _settingValue;

    public SettingKey SettingKey => settingKey;
    public string SettingValue => _settingValue;
    public string SettingDefaultValue => settingDefaultValue;

    public void HandleSettingValueChanged(string value)
    {
        this._settingValue = value;
        onSettingValueChanged?.Invoke(value);
    }

    public void LoadSettingValue(string value)
    {
        this.HandleSettingValueChanged(value);
    }
}
}
