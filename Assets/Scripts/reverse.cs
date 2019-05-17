using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverse : MonoBehaviour
{
    public CPUController cpu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.reverse = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.reverse = false;
        }
    }
}
