using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp32 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(31);
            gm.DebugCheck(31);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(31);
        }
    }
}
