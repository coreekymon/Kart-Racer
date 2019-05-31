using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp26 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(25);
            gm.DebugCheck(25);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(25);
        }
    }
}
