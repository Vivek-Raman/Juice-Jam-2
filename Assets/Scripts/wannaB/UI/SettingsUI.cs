using System.Collections.Generic;
using UnityEngine;

namespace wannaB.UI
{
public class SettingsUI : MonoBehaviour
{
    [SerializeField] private List<SettingUIItem> settingUIItems;

    public void UI_LoadSettingsIntoUI()
    {
        foreach (SettingUIItem item in settingUIItems)
        {
            item.LoadSettingValueIntoUI();
        }
    }

    public void UI_SaveSettings()
    {
        GameManager.Settings.SaveSettings();
    }
}
}
