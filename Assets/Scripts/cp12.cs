using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp12 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(11);
            gm.DebugCheck(11);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(11);
        }
    }
}
