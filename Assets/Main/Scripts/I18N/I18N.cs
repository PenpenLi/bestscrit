﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppSettings;


public class I18N
{
    private static LanguageType language = LanguageType.None;
    public static LanguageType Language { get { return language; } }

    public static void SetLanguage(LanguageType languageType)
    {
        //使用系统默认语言
        if (languageType == LanguageType.None)
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Chinese:
                case SystemLanguage.ChineseSimplified:
                    languageType = LanguageType.ChineseSimplified;
                    break;
                case SystemLanguage.ChineseTraditional:
                    languageType = LanguageType.ChineseTraditional;
                    break;
                case SystemLanguage.English:
                    languageType = LanguageType.English;
                    break;
                default:
                    languageType = LanguageType.English;
                    break;
            }
        }
        if (language != languageType)
        {
            //切换语言，刷新所有label
        }
        language = languageType;
    }

    public static string Get(int stringId)
    {
        switch (language)
        {
            case LanguageType.None:
                SetLanguage(LanguageType.None);
                return Get(stringId);
            case LanguageType.ChineseSimplified:
                return LocalizationTableSettings.Get(stringId).ChineseSimplified;
            case LanguageType.ChineseTraditional:
                return LocalizationTableSettings.Get(stringId).ChineseTraditional;
            case LanguageType.English:
                return LocalizationTableSettings.Get(stringId).English;
            default:
                return LocalizationTableSettings.Get(stringId).ChineseSimplified;
        }
    }
}


