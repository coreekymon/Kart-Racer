using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    public CPUController cpu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            cpu.CPUposReset = other.transform.position;
            cpu.CPUrotReset = other.transform.rotation;
            cpu.ResetTimer();
        }
    }
}
