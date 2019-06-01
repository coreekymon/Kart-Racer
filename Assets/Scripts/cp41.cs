using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp41 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(40);
            gm.DebugCheck(40);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(40);
        }
    }
}
