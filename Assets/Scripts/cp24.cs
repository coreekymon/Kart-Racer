using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp24 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(23);
            gm.DebugCheck(23);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(23);
        }
    }
}
