using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp23 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(22);
            gm.DebugCheck(22);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(22);
        }
    }
}
