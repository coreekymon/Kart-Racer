using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp46 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(45);
            gm.DebugCheck(45);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(45);
        }
    }
}
