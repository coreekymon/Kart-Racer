using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp25 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(24);
            gm.DebugCheck(24);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(24);
        }
    }
}
