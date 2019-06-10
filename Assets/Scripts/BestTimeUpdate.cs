using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BestTimeUpdate : MonoBehaviour
{
    GameObject data;
    SaveData sdata;
    public timer t;
    public string SceneName;
    private void Awake()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        SceneName = CurrentScene.name;
        data = GameObject.FindGameObjectWithTag("savedata");
        if(data != null)
        {
            sdata = data.GetComponent<SaveData>();
        }
    }

    private void Update()
    {
        if(t.raceend == true)
        {
            if(SceneName == "FieldTrack")
            {
                if(t.finalMinutes < sdata.fieldminutes)
                {
                    sdata.fieldminutes = t.finalMinutes;
                    sdata.fieldseconds = t.finalSeconds;
                    sdata.fieldmseconds = t.finalMilliseconds;
                }
                if(t.finalMinutes == sdata.fieldminutes)
                {
                    if(t.finalSeconds < sdata.fieldseconds)
                    {
                        sdata.fieldseconds = t.finalSeconds;
                        sdata.fieldmseconds = t.finalMilliseconds;
                    }
                    if(t.finalSeconds == sdata.fieldseconds)
                    {
                        if(t.finalMilliseconds < sdata.fieldmseconds)
                        {
                            sdata.fieldmseconds = t.finalMilliseconds;
                        }
                    }
                }
            }
            if (SceneName == "SnowyMountainTrack")
            {
                if (t.finalMinutes < sdata.mountainminutes)
                {
                    sdata.mountainminutes = t.finalMinutes;
                    sdata.mountainseconds = t.finalSeconds;
                    sdata.mountainmseconds = t.finalMilliseconds;
                }
                if (t.finalMinutes == sdata.mountainminutes)
                {
                    if (t.finalSeconds < sdata.mountainseconds)
                    {
                        sdata.mountainseconds = t.finalSeconds;
                        sdata.mountainmseconds = t.finalMilliseconds;
                    }
                    if (t.finalSeconds == sdata.mountainseconds)
                    {
                        if (t.finalMilliseconds < sdata.mountainmseconds)
                        {
                            sdata.mountainmseconds = t.finalMilliseconds;
                        }
                    }
                }
            }
            if (SceneName == "DesertTrack")
            {
                if (t.finalMinutes < sdata.desertminutes)
                {
                    sdata.desertminutes = t.finalMinutes;
                    sdata.desertseconds = t.finalSeconds;
                    sdata.desertmseconds = t.finalMilliseconds;
                }
                if (t.finalMinutes == sdata.desertminutes)
                {
                    if (t.finalSeconds < sdata.desertseconds)
                    {
                        sdata.desertseconds = t.finalSeconds;
                        sdata.desertmseconds = t.finalMilliseconds;
                    }
                    if (t.finalSeconds == sdata.desertseconds)
                    {
                        if (t.finalMilliseconds < sdata.desertmseconds)
                        {
                            sdata.desertmseconds = t.finalMilliseconds;
                        }
                    }
                }
            }
            if (SceneName == "MoonTrack")
            {
                if (t.finalMinutes < sdata.moonminutes)
                {
                    sdata.moonminutes = t.finalMinutes;
                    sdata.moonseconds = t.finalSeconds;
                    sdata.moonmseconds = t.finalMilliseconds;
                }
                if (t.finalMinutes == sdata.moonminutes)
                {
                    if (t.finalSeconds < sdata.moonseconds)
                    {
                        sdata.moonseconds = t.finalSeconds;
                        sdata.moonmseconds = t.finalMilliseconds;
                    }
                    if (t.finalSeconds == sdata.moonseconds)
                    {
                        if (t.finalMilliseconds < sdata.moonmseconds)
                        {
                            sdata.moonmseconds = t.finalMilliseconds;
                        }
                    }
                }
            }
            if (SceneName == "CityTrack")
            {
                if (t.finalMinutes < sdata.cityminutes)
                {
                    sdata.cityminutes = t.finalMinutes;
                    sdata.cityseconds = t.finalSeconds;
                    sdata.fieldmseconds = t.finalMilliseconds;
                }
                if (t.finalMinutes == sdata.cityminutes)
                {
                    if (t.finalSeconds < sdata.cityseconds)
                    {
                        sdata.cityseconds = t.finalSeconds;
                        sdata.citymseconds = t.finalMilliseconds;
                    }
                    if (t.finalSeconds == sdata.cityseconds)
                    {
                        if (t.finalMilliseconds < sdata.citymseconds)
                        {
                            sdata.citymseconds = t.finalMilliseconds;
                        }
                    }
                }
            }
        }
    }
}
