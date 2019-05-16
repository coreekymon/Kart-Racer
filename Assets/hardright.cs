using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardright : MonoBehaviour
{
    public CPUController cpu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.hardright = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.hardright = false;
        }
    }
}
