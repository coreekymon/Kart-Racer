using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{
    private bool[] checkpoint = new bool[11];
    public int playerlap = 1;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 10)
        {
            checkpoint[i] = false;
            Debug.Log(checkpoint[i]);
            i = i + 1;
        }
        /*for(int i = 0; i < 11; i++)
        {
            checkpoint[1] = false;
            Debug.Log(checkpoint[i]);
        }*/
    }

    public void SetCheckpoint(int a)
    {
        checkpoint[a] = true;
        Debug.Log("Set Checkpoint");
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
        }
    }
    public void DebugCheck(int b)
    {
        Debug.Log(checkpoint[b]);
    }
}
