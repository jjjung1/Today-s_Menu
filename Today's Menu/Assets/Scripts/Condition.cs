using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public enum Weather
    {
        Sunny,
        Cloudy,
        Rainy,
        Snow,
        Null
    }

    public enum Season
    {
        Spring,
        Summer,
        Fall,
        Winter,
        Null
    }

    public enum DayNight
    {
        Day,
        Night,
        Null
    }

    public Weather W;
    public Season S;
    public DayNight DN;

    public Image icon;
    public Sprite sunny_img;
    public Sprite cloudy_img;
    public Sprite rainy_img;
    public Sprite snow_img;
    public Sprite origin_img;

    private string currentWeatherDescription = "";
    private string apiKey = "f4b438353784b2bdf3d558665d6b1fd3";
    private string city = "Seoul";
    void Start()
    { 
        StartCoroutine(GetWeatherData());
        UpdateIcon();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateIcon();
    }

    void UpdateIcon()
    {
        DateTime now = DateTime.Now;
        W = GetWeather();
        S = GetSeason(now);
        DN = GetDayNight(now);

        switch (W)
        {
            case Weather.Sunny:
                icon.sprite = sunny_img;
                break;
            case Weather.Cloudy:
                icon.sprite = cloudy_img;
                break;
            case Weather.Rainy:
                icon.sprite = rainy_img;
                break;
            case Weather.Snow:
                icon.sprite = snow_img;
                break;
            default:
                icon.sprite = origin_img;
                break;
        }
    }

    Weather GetWeather()
    {
        if (string.IsNullOrEmpty(currentWeatherDescription))
            return Weather.Null;

        if (currentWeatherDescription.Contains("clear")) return Weather.Sunny;
        if (currentWeatherDescription.Contains("cloud")) return Weather.Cloudy;
        if (currentWeatherDescription.Contains("rain")) return Weather.Rainy;
        if (currentWeatherDescription.Contains("snow")) return Weather.Snow;

        return Weather.Null;
    }

    Season GetSeason(DateTime date)
    {
        int month = date.Month;
        if (month >= 3 && month <= 5) return Season.Spring;
        if (month >= 6 && month <= 8) return Season.Summer;
        if (month >= 9 && month <= 11) return Season.Fall;
        if (month == 12 || month == 1 || month == 2) return Season.Winter;
        return Season.Null;
    }

    DayNight GetDayNight(DateTime date)
    {
        int hour = date.Hour;
        if (hour >= 6 && hour < 18) return DayNight.Day;
        if ((0 <= hour && hour < 6) || (hour >= 18 && hour < 24)) return DayNight.Night;
        return DayNight.Null;
    }

    IEnumerator GetWeatherData()
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            // JSON 응답 데이터 출력
            string json = request.downloadHandler.text;

            WeatherResponse weatherResponse = JsonUtility.FromJson<WeatherResponse>(json);
            if (weatherResponse != null && weatherResponse.weather.Length > 0)
            {
                currentWeatherDescription = weatherResponse.weather[0].description;
            }
            else
            {
                Debug.LogError("API 호출 실패: " + request.error);
                currentWeatherDescription = null;
            }
        }
    }
}

[System.Serializable]
public class WeatherResponse
{
    public WeatherInfo[] weather;
}

[System.Serializable]
public class WeatherInfo
{
    public string description;
}