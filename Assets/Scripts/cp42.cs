using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp42 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(41);
            gm.DebugCheck(41);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(41);
        }
    }
}
