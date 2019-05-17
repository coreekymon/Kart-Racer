using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp11 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(10);
            gm.DebugCheck(10);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(10);
        }
    }
}
