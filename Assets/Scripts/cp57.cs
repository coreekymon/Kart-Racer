using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp57 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(56);
            gm.DebugCheck(56);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(56);
        }
    }
}
