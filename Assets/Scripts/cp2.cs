using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp2 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(1);
            gm.DebugCheck(1);
        }
    }
}
