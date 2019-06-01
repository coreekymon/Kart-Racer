using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp48 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(47);
            gm.DebugCheck(47);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(47);
        }
    }
}
