﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefInfo : MonoBehaviour
{
    // Start is called before the first frame update
    const string ADS = "ADS";
    const string PREMIUM = "PREMIUM";
    public static bool IsUsingAd()
    {
        return 1 == PlayerPrefs.GetInt(ADS, 1);
    }
    public static void SetAd(bool on)
    {
        if (on)
        {
            PlayerPrefs.SetInt(ADS, 1);
        }
        else
        {
            PlayerPrefs.SetInt(ADS, 0);
        }
    }
    public static void BuyPremium()
    {
        PlayerPrefs.SetInt(PREMIUM, 1);
    }
    public static bool IsBoughtPremium()
    {
        return 1 == PlayerPrefs.GetInt(PREMIUM, 0);
    }
    public static void FirstInit()
    {
        PlayerPrefs.SetInt(ADS, 1);
        PlayerPrefs.SetInt(PREMIUM, 0);
    }
}
