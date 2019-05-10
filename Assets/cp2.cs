using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp2 : MonoBehaviour
{
    public checkpoints gm;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.SetCheckpoint(1);
        }
    }
}
