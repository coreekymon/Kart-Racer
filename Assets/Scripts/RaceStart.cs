using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceStart : MonoBehaviour
{
    public PlayerController player;
    public CPUController cpu;
    public GameObject timer;
    public Text notify; 
    // Start is called before the first frame update
    void Start()
    {
        GetReady();
        Invoke("Three", 1f);
        Invoke("Two", 2f);
        Invoke("One", 3f);
        Invoke("Go", 4f);
        Invoke("Clear", 5f);
    }

   public void GetReady()
    {
        notify.text = "Get Ready!";
    }
    public void Three()
    {
        notify.text = "3!";
    }
    public void Two()
    {
        notify.text = "2!";
    }
    public void One()
    {
        notify.text = "1!";
    }
    public void Go()
    {
        notify.text = "Go!";
        player.ControlEnable();
        cpu.ControlEnable();
        timer.SetActive(true);
    }
    public void Clear()
    {
        notify.text = "";
    }
}
