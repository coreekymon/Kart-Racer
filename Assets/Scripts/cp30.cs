using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp30 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(29);
            gm.DebugCheck(29);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(29);
        }
    }
}
