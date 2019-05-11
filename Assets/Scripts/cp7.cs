using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp7 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(6);
            gm.DebugCheck(6);
        }
    }
}
