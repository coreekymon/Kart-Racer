using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestCityTime : MonoBehaviour
{
    public Text besttime;
    private void Awake()
    {
        GameObject data = GameObject.FindGameObjectWithTag("savedata");
        if (data != null)
        {
            SaveData sdata = data.GetComponent<SaveData>();
            if (sdata.cityseconds < 10)
            {
                if (sdata.citymseconds < 10)
                {
                    besttime.text = sdata.cityminutes + ":0" + sdata.cityseconds + ":0" + sdata.citymseconds;
                }
                else
                {
                    besttime.text = sdata.cityminutes + ":0" + sdata.cityseconds + ":" + sdata.citymseconds;
                }
            }
            else
            {
                if (sdata.citymseconds < 10)
                {
                    besttime.text = sdata.cityminutes + ":" + sdata.cityseconds + ":0" + sdata.citymseconds;
                }
                else
                {
                    besttime.text = sdata.cityminutes + ":" + sdata.cityseconds + ":" + sdata.citymseconds;
                }
            }
        }
    }
}
