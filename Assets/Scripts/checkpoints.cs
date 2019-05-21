using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpoints : MonoBehaviour
{
    public bool[] checkpoint = new bool[11];
    public bool[] cpucheckpoint = new bool[11];
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
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 11)
        {
            checkpoint[i] = false;
            //Debug.Log(checkpoint[i]);
            i = i + 1;
        }
        int j = 0;
        while (j < 11)
        {
            cpucheckpoint[j] = false;
            
            j = j + 1;
        }
    }

    private void Update()
    {
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
        for (int k = 0; k < 11; k++)
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
        if (playerlap < 4)
        {
            notify.text = "Lap " + playerlap + "/3";
            Invoke("Clear", 1f);
        }
    }
    public void ResetCheckpoints()
    {
        for (int i = 0; i < 11; i++)
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
        for (int i = 0; i < 11; i++)
        {
            cpucheckpoint[i] = false;
            //Debug.Log(checkpoint[i]);
        }
    }

    public void DebugCheck(int b)
    {
        //Debug.Log(checkpoint[b]);
        return;
    }
    public void Clear()
    {
        notify.text = "";
    }
}
