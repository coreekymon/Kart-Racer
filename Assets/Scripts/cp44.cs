using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp44 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(43);
            gm.DebugCheck(43);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(43);
        }
    }
}
