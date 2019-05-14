using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp8 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(7);
            gm.DebugCheck(7);
        }
    }
}
