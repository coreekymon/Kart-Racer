using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slightleft : MonoBehaviour
{
    public CPUController cpu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.slightleft = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint"))
        {
            cpu.slightleft = false;
        }
    }
}
