using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 60f;
    bool isTimerRunning = false;
    float currTime;
    public Text timerTxt;
    public CollectManager cm;
   
    private void Start()
    {
        isTimerRunning = true;
        currTime=timeValue;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currTime -= Time.deltaTime;

            if (currTime <= 0.0f && !cm.allCollected)
            {
                currTime = 0.0f;
                isTimerRunning = false;
                GameManager.instance.GameOverScreen(false);
            }

            if (cm.allCollected)
            {
                GameManager.instance.GameOverScreen(true);
                isTimerRunning = false;
            }
        
           
               UpdateTimer();
        }


    }
    void UpdateTimer()
    {
        int min = Mathf.FloorToInt(currTime / 60.0f);
        int sec = Mathf.FloorToInt(currTime % 60.0f);

        timerTxt.text = string.Format("{0:00}:{1:00}",min,sec);

     
    }

}
