using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp36 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(35);
            gm.DebugCheck(35);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(35);
        }
    }
}
