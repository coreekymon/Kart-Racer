using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp17 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(16);
            gm.DebugCheck(16);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(16);
        }
    }
}
