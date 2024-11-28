using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeControl : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        DateTime now = DateTime.Now;

        string timeMessage = MakeTimeMessage(now.Hour);

        string printMessage = $"{now:MM�� dd����} {timeMessage}";

        timeText.text = printMessage;
    }

    string MakeTimeMessage(int hour)
    {
        if (hour >= 5 && hour < 11)
        {
            return "��ħ";
        }
        else if (hour >= 11 && hour < 16)
        {
            return "����";
        }
        else if (hour >= 16 && hour < 22)
        {
            return "����";
        }
        else
        {
            return "�߽�";
        }
    }
}