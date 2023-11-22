using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocaleController : MonoBehaviour
{
    private bool active = false; // Check coroutine is not called few times

    public void ChangeLocale(int _localeID) // Function for buttons
    {
        if (active == true)
            return;
        StartCoroutine(SetLocale(_localeID));
    }

    // 
    IEnumerator SetLocale(int _localeID)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation; // Check if localization is ready
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID]; // Select locale
        active = false;
    }
}
