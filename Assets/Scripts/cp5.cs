using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp5 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(4);
            gm.DebugCheck(4);
        }
    }
}
