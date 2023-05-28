using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class timer : MonoBehaviour
{
    public float countdownTime = 30f; 
    public TextMeshProUGUI countdownText; 
    private float timeRemaining;
    public GameObject panel;
    void Start()
    {
        panel.SetActive(false);
        timeRemaining = countdownTime;
        UpdateCountdownText();
    }
    private void Update()
    {
        if (timeRemaining > 0f)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0f)
            {
                timeRemaining = 0f;  
                openPanel();
            }
            UpdateCountdownText();
            
        }
    }
    private void UpdateCountdownText()
    {
        int seconds = Mathf.CeilToInt(timeRemaining);
        countdownText.text = seconds.ToString();
    }
    void openPanel()
    {
        panel.SetActive(true);
    }
}
