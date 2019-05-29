using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp20 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(19);
            gm.DebugCheck(19);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(19);
        }
    }
}
