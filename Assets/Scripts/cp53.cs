using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp53 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(52);
            gm.DebugCheck(52);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(52);
        }
    }
}
