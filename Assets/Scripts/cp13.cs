using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp13 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(12);
            gm.DebugCheck(12);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(12);
        }
    }
}
