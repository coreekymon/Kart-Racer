using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp27 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(26);
            gm.DebugCheck(26);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(26);
        }
    }
}
