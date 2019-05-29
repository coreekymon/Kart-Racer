using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp18 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(17);
            gm.DebugCheck(17);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(17);
        }
    }
}
