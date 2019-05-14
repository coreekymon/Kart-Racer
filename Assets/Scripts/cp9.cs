using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp9 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(8);
            gm.DebugCheck(8);
        }
    }
}
