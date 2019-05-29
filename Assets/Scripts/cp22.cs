using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp22 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(21);
            gm.DebugCheck(21);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(21);
        }
    }
}
