using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp28 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(27);
            gm.DebugCheck(27);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(27);
        }
    }
}
