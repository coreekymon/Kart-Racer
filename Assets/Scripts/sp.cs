using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour
{
    public checkpoints gm;
    public int cp = 0;
    public int cpucp = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for(int a = 0; a < gm.cpnumber; a++)
            {
                if (gm.checkpoint[a])
                {
                    cp = cp + 1;
                }
            }
            if(cp == gm.cpnumber)
            {
                if (gm.playerlap == 3)
                {
                    gm.Nextlap();
                    Debug.Log("Finish!");
                }
                if (gm.playerlap < 3)
                {
                    gm.Nextlap();
                    Debug.Log(gm.playerlap);
                    gm.ResetCheckpoints();
                    cp = 0;
                }

            }
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            for (int b = 0; b < gm.cpnumber; b++)
            {
                if (gm.cpucheckpoint[b])
                {
                    cpucp = cpucp + 1;
                }
            }
            if (cpucp == gm.cpnumber)
            {
                if (gm.CPUlap == 3)
                {
                    gm.CPUNextlap();
                    Debug.Log("CPU Finish!");
                }
                if (gm.CPUlap < 3)
                {
                    gm.CPUNextlap();
                    Debug.Log(gm.CPUlap);
                    gm.CPUResetCheckpoints();
                    cpucp = 0;
                }
            }
        }
    }
}
