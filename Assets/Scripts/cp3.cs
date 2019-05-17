using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp3 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(2);
            gm.DebugCheck(2);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(2);
        }
    }
}
