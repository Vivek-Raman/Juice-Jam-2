using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace wannaB.UI
{
public class SliderSettingUIItem : SettingUIItem
{
    [SerializeField] private Slider slider;

    public void HandleSliderValueChanged(float value)
    {
        settingItem.HandleSettingValueChanged(value.ToString(CultureInfo.InvariantCulture));
    }

    public override void LoadSettingValueIntoUI()
    {
        slider.SetValueWithoutNotify(float.Parse(SettingValue, CultureInfo.InvariantCulture));
    }
}
}
