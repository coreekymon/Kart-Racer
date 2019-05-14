using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float rawTime = 0f;
    float lapOneMilliseconds = 0f;
    int lapOneSeconds = 0;
    int lapOneMinutes = 0;
    float lapTwoMilliseconds = 0f;
    int lapTwoSeconds = 0;
    int lapTwoMinutes = 0;
    float lapThreeMilliseconds = 0f;
    int lapThreeSeconds = 0;
    int lapThreeMinutes = 0;
    float finalMilliseconds = 0f;
    int finalSeconds = 0;
    int finalMinutes = 0;
    public Text lapOne;
    public Text lapTwo;
    public Text lapThree;
    public Text finalTime;
    public checkpoints gm;

    // Update is called once per frame
    void Update()
    {
        if (gm.playerlap == 1)
        {
            if (rawTime >= 1)
            {
                lapOneSeconds = lapOneSeconds + 1;
                rawTime = 0;
            }
            if (lapOneSeconds >= 60)
            {
                lapOneMinutes = lapOneMinutes + 1;
                lapOneSeconds = 0;
            }
            rawTime = rawTime + Time.deltaTime;
            lapOneMilliseconds = Mathf.Round(rawTime * 100);
            if (lapOneMilliseconds > 100)
            {
                lapOneMilliseconds = 0;
            }
            lapOne.text = "Lap 1: " + lapOneMinutes + ":" + lapOneSeconds + ":" + lapOneMilliseconds;
        }
        if (gm.playerlap == 2)
        {
            if (rawTime >= 1)
            {
                lapTwoSeconds = lapTwoSeconds + 1;
                rawTime = 0;
            }
            if (lapTwoSeconds >= 60)
            {
                lapTwoMinutes = lapTwoMinutes + 1;
                lapTwoSeconds = 0;
            }
            rawTime = rawTime + Time.deltaTime;
            lapTwoMilliseconds = Mathf.Round(rawTime * 100);
            if (lapTwoMilliseconds > 100)
            {
                lapTwoMilliseconds = 0;
            }
            lapTwo.text = "Lap 2: " + lapTwoMinutes + ":" + lapTwoSeconds + ":" + lapTwoMilliseconds;
        }
        if (gm.playerlap == 3)
        {
            if (rawTime >= 1)
            {
                lapThreeSeconds = lapThreeSeconds + 1;
                rawTime = 0;
            }
            if (lapThreeSeconds >= 60)
            {
                lapThreeMinutes = lapThreeMinutes + 1;
                lapThreeSeconds = 0;
            }
            rawTime = rawTime + Time.deltaTime;
            lapThreeMilliseconds = Mathf.Round(rawTime * 100);
            if (lapThreeMilliseconds > 100)
            {
                lapThreeMilliseconds = 0;
            }
            lapThree.text = "Lap 3: " + lapThreeMinutes + ":" + lapThreeSeconds + ":" + lapThreeMilliseconds;
        }
        if(gm.playerlap > 3)
        {
            finalMilliseconds = lapOneMilliseconds + lapTwoMilliseconds + lapThreeMilliseconds;
            finalSeconds = lapOneSeconds + lapTwoSeconds + lapThreeSeconds;
            finalMinutes = lapOneMinutes + lapTwoMinutes + lapThreeMinutes;
            while(finalMilliseconds >= 100)
            {
                finalSeconds = finalSeconds + 1;
                finalMilliseconds = finalMilliseconds - 100;
            }
            while(finalSeconds >= 60)
            {
                finalMinutes = finalMinutes + 1;
                finalSeconds = finalSeconds - 60;
            }
            if (finalSeconds < 10 && finalMilliseconds < 10)
            {
                finalTime.text = "Final Time:" + finalMinutes + ":0" + finalSeconds + ":0" + finalMilliseconds;
            }
            if (finalSeconds >= 10 && finalMilliseconds < 10)
            {
                finalTime.text = "Final Time:" + finalMinutes + ":" + finalSeconds + ":0" + finalMilliseconds;
            }
            if (finalSeconds < 10 && finalMilliseconds >= 10)
            {
                finalTime.text = "Final Time:" + finalMinutes + ":0" + finalSeconds + ":" + finalMilliseconds;
            }
            if (finalSeconds >= 10 && finalMilliseconds >= 10)
            {
                finalTime.text = "Final Time:" + finalMinutes + ":" + finalSeconds + ":" + finalMilliseconds;
            }
        }
    }
}
