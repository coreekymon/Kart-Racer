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
    }
}
