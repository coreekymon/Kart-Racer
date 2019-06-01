using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp45 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(44);
            gm.DebugCheck(44);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(44);
        }
    }
}
