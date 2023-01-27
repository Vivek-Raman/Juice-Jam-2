using TMPro;
using UnityEngine;
using wannaB.Settings;

namespace wannaB.UI
{
public abstract class SettingUIItem : MonoBehaviour
{
    [SerializeField] protected SettingKey settingKey;
    protected SettingItem settingItem;

    private void Awake()
    {
        settingItem = GameManager.Settings.Settings[settingKey];
        this.transform.GetChild(0).GetComponent<TMP_Text>().text = GetDisplayNameForSettingKey(settingItem.SettingKey);
    }

    // Use settingItem.SettingValue to populate UI in inheritors
    protected string SettingValue => settingItem.SettingValue;
    public abstract void LoadSettingValueIntoUI();

    private string GetDisplayNameForSettingKey(SettingKey key)
    {
        switch (key)
        {
            case SettingKey.Null:
                return "Null";
            case SettingKey.InvertY:
                return "Invert Mouse Y";
            case SettingKey.ScreenShake:
                return "Screen Shake";
            case SettingKey.MasterVolume:
                return "Master Volume";

            default:
                return key.ToString();
        }
    }
}
}
