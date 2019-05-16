using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slightright : MonoBehaviour
{
    public CPUController cpu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.slightright = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.slightright = false;
        }
    }
}
