using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class checkpoints : MonoBehaviour
{
    public bool[] checkpoint;
    public bool[] cpucheckpoint;
    public int playerlap = 1;
    public int CPUlap = 1;
    public PlayerController pc;
    public CPUController cpu;
    public Text finish;
    public Text notify;
    private int playerpos = 0;
    private int cpupos = 0;
    public int playerplace = 1;
    public Text place;
    public GameObject trackselect;
    public GameObject retry;
    public int cpnumber = 0;
    public string SceneName;
    // Start is called before the first frame update
    private void Awake()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        SceneName = CurrentScene.name;
        if(SceneName == "FieldTrack")
        {
            cpnumber = 11;
        }
        if(SceneName == "CityTrack")
        {
            cpnumber = 25;
        }
        if(SceneName == "SnowyMountainTrack")
        {
            cpnumber = 29;
        }
        if (SceneName == "DesertTrack")
        {
            cpnumber = 29;
        }
        if (SceneName == "MoonTrack")
        {
            cpnumber = 57;
        }
        checkpoint = new bool[cpnumber];
        cpucheckpoint = new bool[cpnumber];
    }
    void Start()
    {
        int i = 0;
        while (i < cpnumber)
        {
            checkpoint[i] = false;
            //Debug.Log(checkpoint[i]);
            i = i + 1;
        }
        int j = 0;
        while (j < cpnumber)
        {
            cpucheckpoint[j] = false;
            
            j = j + 1;
        }
    }

    private void Update()
    {
        if(SceneName == "SnowyMountainTrack")
        {
            if (playerlap > 1)
            {
                pc.ControlDisable();
                cpu.ControlDisable();
                finish.text = "Finish!\nYou Win!";
                trackselect.SetActive(true);
                retry.SetActive(true);
            }
            if (CPUlap > 1)
            {
                pc.ControlDisable();
                cpu.ControlDisable();
                finish.text = "Finish\nYou Lose";
                trackselect.SetActive(true);
                retry.SetActive(true);
            }
        }
        if(playerlap > 3)
        {
            pc.ControlDisable();
            cpu.ControlDisable();
            finish.text = "Finish!\nYou Win!";
            trackselect.SetActive(true);
            retry.SetActive(true);
        }
        if(CPUlap > 3)
        {
            pc.ControlDisable();
            cpu.ControlDisable();
            finish.text = "Finish\nYou Lose";
            trackselect.SetActive(true);
            retry.SetActive(true);
        }
        for (int k = 0; k < cpnumber; k++)
        {
            if (checkpoint[k])
            {
                playerpos = playerpos + 1;
            }
            if (cpucheckpoint[k])
            {
                cpupos = cpupos + 1;
            }
        }
        if(playerlap == CPUlap)
        {
            if(cpupos != playerpos)
            {
                if(cpupos > playerpos)
                {
                    playerplace = 2;
                }
                else
                {
                    playerplace = 1;
                }
            }
        }
        else
        {
            if(CPUlap > playerlap)
            {
                playerplace = 2;
            }
            else
            {
                playerplace = 1;
            }
        }
        place.text = "Place " + playerplace + "/2";
        playerpos = 0;
        cpupos = 0;
    }

    public void SetCheckpoint(int a)
    {
        checkpoint[a] = true;
        //Debug.Log("Set Checkpoint");
    }
    public void Nextlap()
    {
        playerlap = playerlap + 1;
        if (playerlap < 4 && SceneName != "SnowyMountainTrack")
        {
            notify.text = "Lap " + playerlap + "/3";
            Invoke("Clear", 1f);
        }
    }
    public void ResetCheckpoints()
    {
        for (int i = 0; i < cpnumber; i++)
        {
            checkpoint[i] = false;
            //Debug.Log(checkpoint[i]);
        }
    }

    public void CPUSetCheckpoint(int c)
    {
        cpucheckpoint[c] = true;
        //Debug.Log("Set Checkpoint");
    }
    public void CPUNextlap()
    {
        CPUlap = CPUlap + 1;
    }
    public void CPUResetCheckpoints()
    {
        for (int i = 0; i < cpnumber; i++)
        {
            cpucheckpoint[i] = false;
            //Debug.Log(checkpoint[i]);
        }
    }

    public void DebugCheck(int b)
    {
        Debug.Log(b);
        Debug.Log(checkpoint[b]);
        return;
    }
    public void Clear()
    {
        notify.text = "";
    }
}
