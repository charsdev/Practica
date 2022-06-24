using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Chars.Tools;
using System;

public class UIManager : Singleton<UIManager>
{
    public TextMeshProUGUI ScoreText;

    public void RefreshPoints()
    {
        ScoreText.SetText(Global.Score.ToString("Score:0"));
    }

   
}

