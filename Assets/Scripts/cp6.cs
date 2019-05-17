﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp6 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(5);
            gm.DebugCheck(5);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(5);
        }
    }
}
