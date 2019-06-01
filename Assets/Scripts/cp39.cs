using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp39 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(38);
            gm.DebugCheck(38);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(38);
        }
    }
}
