using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp49 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(48);
            gm.DebugCheck(48);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(48);
        }
    }
}
