using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp40 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(39);
            gm.DebugCheck(39);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(39);
        }
    }
}
