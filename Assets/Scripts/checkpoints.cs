using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpoints : MonoBehaviour
{
    public bool[] checkpoint = new bool[11];
    public int playerlap = 1;
    public PlayerController pc;
    public Text finish;
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
        /*for(int i = 0; i < 11; i++)
        {
            checkpoint[1] = false;
            Debug.Log(checkpoint[i]);
        }*/
    }

    private void Update()
    {
        if(playerlap > 3)
        {
            pc.ControlDisable();
            finish.text = "Finish!";
        }
    }

    public void SetCheckpoint(int a)
    {
        checkpoint[a] = true;
        //Debug.Log("Set Checkpoint");
    }
    public void Nextlap()
    {
        playerlap = playerlap + 1;
    }
    public void ResetCheckpoints()
    {
        for (int i = 0; i < 11; i++)
        {
            checkpoint[i] = false;
            //Debug.Log(checkpoint[i]);
        }
    }
    public void DebugCheck(int b)
    {
        //Debug.Log(checkpoint[b]);
        return;
    }
}
