﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public CPUController cpu;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CPU"))
        {
            cpu.Boost();
            this.enabled = false;
        }
    }
}
