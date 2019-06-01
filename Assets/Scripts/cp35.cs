using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp35 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(34);
            gm.DebugCheck(34);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(34);
        }
    }
}
