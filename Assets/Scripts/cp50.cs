using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp50 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(49);
            gm.DebugCheck(49);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(49);
        }
    }
}
