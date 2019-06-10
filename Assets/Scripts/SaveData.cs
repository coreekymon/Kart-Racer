using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public int fieldminutes = 2;
    public int fieldseconds = 0;
    public float fieldmseconds = 0;
    public int mountainminutes = 3;
    public int mountainseconds = 0;
    public float mountainmseconds = 0;
    public int desertminutes = 7;
    public int desertseconds = 0;
    public float desertmseconds = 0;
    public int moonminutes = 7;
    public int moonseconds = 0;
    public float moonmseconds = 0;
    public int cityminutes = 10;
    public int cityseconds = 0;
    public float citymseconds = 0;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("savedata");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
