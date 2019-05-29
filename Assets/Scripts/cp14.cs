using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp14 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(13);
            gm.DebugCheck(13);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(13);
        }
    }
}
