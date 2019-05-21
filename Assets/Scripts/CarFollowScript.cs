using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollowScript : MonoBehaviour
{
    public GameObject playerPos;
    public PlayerController pc;

    // Update is called once per frame
    void Update()
    {
        if (pc.controlEnabled || !pc.racestart)
        {
            transform.position = playerPos.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, playerPos.transform.rotation.y, transform.rotation.z, playerPos.transform.rotation.w);
        }
        else
        {
            if (pc.speed != 0)
            {
                transform.position = playerPos.transform.position;
                transform.rotation = new Quaternion(transform.rotation.x, playerPos.transform.rotation.y, transform.rotation.z, playerPos.transform.rotation.w);
            }
            if(pc.speed == 0)
            {
                transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
            }
        }
    }
}
