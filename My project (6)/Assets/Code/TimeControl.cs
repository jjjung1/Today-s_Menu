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

        string printMessage = $"{now:MM월 dd일의} {timeMessage}";

        timeText.text = printMessage;
    }

    string MakeTimeMessage(int hour)
    {
        if (hour >= 5 && hour < 11)
        {
            return "아침";
        }
        else if (hour >= 11 && hour < 16)
        {
            return "점심";
        }
        else if (hour >= 16 && hour < 22)
        {
            return "저녁";
        }
        else
        {
            return "야식";
        }
    }
}