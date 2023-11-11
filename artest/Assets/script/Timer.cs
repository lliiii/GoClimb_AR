using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float elapsedTime = 0f;
    

    private bool isRunning = false; // Flag to control timer state

    public TextMeshProUGUI timerText; // Reference to the UI Text element

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerUI();
        }
    }

    public void StartTimer()
    {
        ResetTimer();
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        elapsedTime = 0f;
        UpdateTimerUI();
    } 

    public string GetFormattedTime()
    {
        int hours = Mathf.FloorToInt(elapsedTime / 3600); // Calculate hours
        int minutes = Mathf.FloorToInt((elapsedTime % 3600) / 60); // Calculate minutes
        int seconds = Mathf.FloorToInt(elapsedTime % 60); // Calculate seconds

        string timerString = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        return timerString;
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + GetFormattedTime();
    }

}
