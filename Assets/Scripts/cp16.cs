using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp16 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(15);
            gm.DebugCheck(15);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(15);
        }
    }
}
