using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    public GameObject lightsON;
    public GameObject lightsOFF;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lightsON.SetActive(true);
            lightsOFF.SetActive(false);
        }
    }
}
