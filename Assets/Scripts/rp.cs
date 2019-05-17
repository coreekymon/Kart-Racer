using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rp : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.ResetCheckpoints();
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUResetCheckpoints();
        }
    }
}
