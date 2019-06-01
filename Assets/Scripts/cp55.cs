using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp55 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(54);
            gm.DebugCheck(54);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(54);
        }
    }
}
