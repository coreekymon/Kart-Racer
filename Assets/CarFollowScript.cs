using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollowScript : MonoBehaviour
{
    public GameObject playerPos;
    
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = playerPos.transform.position;
        transform.rotation = new Quaternion(transform.rotation.x, playerPos.transform.rotation.y, transform.rotation.z, playerPos.transform.rotation.w);
    }
}
