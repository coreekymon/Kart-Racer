using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp10 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(9);
            gm.DebugCheck(9);
        }
    }
}
