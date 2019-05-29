using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp19 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(18);
            gm.DebugCheck(18);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(18);
        }
    }
}
