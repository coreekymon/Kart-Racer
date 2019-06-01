using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp37 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(36);
            gm.DebugCheck(36);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(36);
        }
    }
}
