using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp51 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(50);
            gm.DebugCheck(50);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(50);
        }
    }

}
