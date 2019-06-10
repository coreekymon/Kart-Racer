using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestFieldTime : MonoBehaviour
{
    public Text besttime;
    private void Awake()
    {
        GameObject data = GameObject.FindGameObjectWithTag("savedata");
        if (data != null)
        {
            SaveData sdata = data.GetComponent<SaveData>();
            if (sdata.fieldseconds < 10)
            {
                if (sdata.fieldmseconds < 10)
                {
                    besttime.text = sdata.fieldminutes + ":0" + sdata.fieldseconds + ":0" + sdata.fieldmseconds;
                }
                else
                {
                    besttime.text = sdata.fieldminutes + ":0" + sdata.fieldseconds + ":" + sdata.fieldmseconds;
                }
            }
            else
            {
                if (sdata.fieldmseconds < 10)
                {
                    besttime.text = sdata.fieldminutes + ":" + sdata.fieldseconds + ":0" + sdata.fieldmseconds;
                }
                else
                {
                    besttime.text = sdata.fieldminutes + ":" + sdata.fieldseconds + ":" + sdata.fieldmseconds;
                }
            }
        }
    }
}
