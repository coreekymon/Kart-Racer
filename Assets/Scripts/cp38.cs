using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp38 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(37);
            gm.DebugCheck(37);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(37);
        }
    }
}
