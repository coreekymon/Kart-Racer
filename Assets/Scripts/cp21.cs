using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp21 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(20);
            gm.DebugCheck(20);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(20);
        }
    }
}
