using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(gm.checkpoint[0] && gm.checkpoint[1] && gm.checkpoint[2] && gm.checkpoint[3] && gm.checkpoint[4] && gm.checkpoint[5] && gm.checkpoint[6] && gm.checkpoint[7] && gm.checkpoint[8] && gm.checkpoint[9] && gm.checkpoint[10])
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
                }
            }
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            if (gm.cpucheckpoint[0] && gm.cpucheckpoint[1] && gm.cpucheckpoint[2] && gm.cpucheckpoint[3] && gm.cpucheckpoint[4] && gm.cpucheckpoint[5] && gm.cpucheckpoint[6] && gm.cpucheckpoint[7] && gm.cpucheckpoint[8] && gm.cpucheckpoint[9] && gm.cpucheckpoint[10])
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
                }
            }
        }
    }
}
