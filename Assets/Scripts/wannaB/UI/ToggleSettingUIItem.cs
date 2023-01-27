using UnityEngine;
using UnityEngine.UI;

namespace wannaB.UI
{
public class ToggleSettingUIItem : SettingUIItem
{
    [SerializeField] private Toggle toggle;

    public void HandleToggleValueChanged(bool value)
    {
        settingItem.HandleSettingValueChanged(value.ToString());
    }

    public override void LoadSettingValueIntoUI()
    {
        toggle.SetIsOnWithoutNotify(bool.Parse(SettingValue));
    }
}
}
