using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp15 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(14);
            gm.DebugCheck(14);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(14);
        }
    }
}
