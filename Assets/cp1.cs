using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp1 : MonoBehaviour
{
    public checkpoints gm;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit");
            gm.SetCheckpoint(0);
            gm.DebugCheck(0);
        }
    }
}
