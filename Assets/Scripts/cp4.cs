using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp4 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(3);
            gm.DebugCheck(3);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(3);
        }
    }
}
