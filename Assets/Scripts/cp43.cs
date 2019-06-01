using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp43 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(42);
            gm.DebugCheck(42);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(42);
        }
    }
}
