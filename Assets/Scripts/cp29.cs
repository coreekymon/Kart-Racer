using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp29 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(28);
            gm.DebugCheck(28);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(28);
        }
    }
}
