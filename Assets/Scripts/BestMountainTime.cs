using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestMountainTime : MonoBehaviour
{
    public Text besttime;
    private void Awake()
    {
        GameObject data = GameObject.FindGameObjectWithTag("savedata");
        if (data != null)
        {
            SaveData sdata = data.GetComponent<SaveData>();
            if (sdata.mountainseconds < 10)
            {
                if (sdata.mountainmseconds < 10)
                {
                    besttime.text = sdata.mountainminutes + ":0" + sdata.mountainseconds + ":0" + sdata.mountainmseconds;
                }
                else
                {
                    besttime.text = sdata.mountainminutes + ":0" + sdata.mountainseconds + ":" + sdata.mountainmseconds;
                }
            }
            else
            {
                if (sdata.mountainmseconds < 10)
                {
                    besttime.text = sdata.mountainminutes + ":" + sdata.mountainseconds + ":0" + sdata.mountainmseconds;
                }
                else
                {
                    besttime.text = sdata.mountainminutes + ":" + sdata.mountainseconds + ":" + sdata.mountainmseconds;
                }
            }
        }
    }
}
