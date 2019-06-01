using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp34 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(33);
            gm.DebugCheck(33);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(33);
        }
    }
}
