﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp1 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(0);
            gm.DebugCheck(0);
        }

        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(0);
        }
    }
}
