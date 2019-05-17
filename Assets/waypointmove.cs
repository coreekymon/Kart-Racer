using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointmove : MonoBehaviour
{
    public GameObject cp1;
    public GameObject cp2;
    public GameObject cp3;
    public GameObject cp4;
    public GameObject cp5;
    public GameObject cp6;
    public GameObject cp7;
    public GameObject cp8;
    public GameObject cp9;
    public GameObject cp10;
    public GameObject cp11;
    public GameObject cp12;
    public checkpoints gm;

    // Update is called once per frame
    void Update()
    {

        if (gm.cpucheckpoint[0])
        {
            if (gm.cpucheckpoint[1])
            {
                if (gm.cpucheckpoint[2])
                {
                    if (gm.cpucheckpoint[3])
                    {
                        if (gm.cpucheckpoint[4])
                        {
                            if (gm.cpucheckpoint[5])
                            {
                                if (gm.cpucheckpoint[6])
                                {
                                    if (gm.cpucheckpoint[7])
                                    {
                                        if (gm.cpucheckpoint[8])
                                        {
                                            if (gm.cpucheckpoint[9])
                                            {
                                                if (gm.cpucheckpoint[10])
                                                {
                                                    transform.position = cp12.gameObject.transform.position;
                                                }
                                                else
                                                {
                                                    transform.position = cp11.gameObject.transform.position;
                                                }
                                            }
                                            else
                                            {
                                                transform.position = cp10.gameObject.transform.position;
                                            }
                                        }
                                        else
                                        {
                                            transform.position = cp9.gameObject.transform.position;
                                        }
                                    }
                                    else
                                    {
                                        transform.position = cp8.gameObject.transform.position;
                                    }
                                }
                                else
                                {
                                    transform.position = cp7.gameObject.transform.position;
                                }
                            }
                            else
                            {
                                transform.position = cp6.gameObject.transform.position;
                            }
                        }
                        else
                        {
                            transform.position = cp5.gameObject.transform.position;
                        }
                    }
                    else
                    {
                        transform.position = cp4.gameObject.transform.position;
                    }
                }
                else
                {
                    transform.position = cp3.gameObject.transform.position;
                }
            }
            else
            {
                transform.position = cp2.gameObject.transform.position;
            }
        }
        else
        {
            transform.position = cp1.gameObject.transform.position;
        }
        
    }
}
