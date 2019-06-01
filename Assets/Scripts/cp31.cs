using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp31 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(30);
            gm.DebugCheck(30);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(30);
        }
    }
}
