using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestDesetTime : MonoBehaviour
{
    public Text besttime;
    private void Awake()
    {
        GameObject data = GameObject.FindGameObjectWithTag("savedata");
        if (data != null)
        {
            SaveData sdata = data.GetComponent<SaveData>();
            if (sdata.desertseconds < 10)
            {
                if (sdata.desertmseconds < 10)
                {
                    besttime.text = sdata.desertminutes + ":0" + sdata.desertseconds + ":0" + sdata.desertmseconds;
                }
                else
                {
                    besttime.text = sdata.desertminutes + ":0" + sdata.desertseconds + ":" + sdata.desertmseconds;
                }
            }
            else
            {
                if (sdata.desertmseconds < 10)
                {
                    besttime.text = sdata.desertminutes + ":" + sdata.desertseconds + ":0" + sdata.desertmseconds;
                }
                else
                {
                    besttime.text = sdata.desertminutes + ":" + sdata.desertseconds + ":" + sdata.desertmseconds;
                }
            }
        }
    }
}
