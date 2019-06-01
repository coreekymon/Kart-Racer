using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp47 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(46);
            gm.DebugCheck(46);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(46);
        }
    }
}
