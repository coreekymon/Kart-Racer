﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp33 : MonoBehaviour
{
    public checkpoints gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(32);
            gm.DebugCheck(32);
        }
        if (other.gameObject.CompareTag("CPU"))
        {
            gm.CPUSetCheckpoint(32);
        }
    }
}
