using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestMoonTime : MonoBehaviour
{
    public Text besttime;
    private void Awake()
    {
        GameObject data = GameObject.FindGameObjectWithTag("savedata");
        if (data != null)
        {
            SaveData sdata = data.GetComponent<SaveData>();
            if (sdata.moonseconds < 10)
            {
                if (sdata.moonmseconds < 10)
                {
                    besttime.text = sdata.moonminutes + ":0" + sdata.moonseconds + ":0" + sdata.moonmseconds;
                }
                else
                {
                    besttime.text = sdata.moonminutes + ":0" + sdata.moonseconds + ":" + sdata.moonmseconds;
                }
            }
            else
            {
                if (sdata.moonmseconds < 10)
                {
                    besttime.text = sdata.moonminutes + ":" + sdata.moonseconds + ":0" + sdata.moonmseconds;
                }
                else
                {
                    besttime.text = sdata.moonminutes + ":" + sdata.moonseconds + ":" + sdata.moonmseconds;
                }
            }
        }
    }
}
