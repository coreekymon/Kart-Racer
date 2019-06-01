using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp54 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(53);
            gm.DebugCheck(53);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(53);
        }
    }
}
