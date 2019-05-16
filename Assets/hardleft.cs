using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardleft : MonoBehaviour
{
    public CPUController cpu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.hardleft = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.hardleft = false;
        }
    }
}
