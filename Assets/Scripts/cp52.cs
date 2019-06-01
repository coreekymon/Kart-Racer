using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp52 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(51);
            gm.DebugCheck(51);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(51);
        }
    }
}
