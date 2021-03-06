using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timercounter : MonoBehaviour
{
    public float timeValue = 300;
    public Text countdownText;
    public bool Death = false;
    Animator Child;

    // Use this for inizialization
    void Start ()
    {
        Child = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeToDisplay <= 0f)
        {
            Death = true;
        }

    }

}
