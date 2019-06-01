using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp56 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(55);
            gm.DebugCheck(55);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(55);
        }
    }
}
