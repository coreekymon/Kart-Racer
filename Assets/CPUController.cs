using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUController : MonoBehaviour
{
    public float CPUspeed = 0f;
    public float CPUmaxspeed = 3f;
    private float CPUturn = 0f;
    public Rigidbody CPUrb;
    public bool CPUgrounded = false;
    public bool CPUroughground = false;
    public Vector3 CPUposReset;
    public Quaternion CPUrotReset;
    public bool CPUcontrolEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        CPUrb = GetComponent<Rigidbody>();
        CPUposReset = transform.position;
        CPUrotReset = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Gas();
    }

    private void FixedUpdate()
    {
        CPUrb.MovePosition(transform.position + transform.forward * CPUspeed);
        Quaternion rotate = Quaternion.Euler(0f, CPUturn * 45f * Time.deltaTime, 0f);
        CPUrb.MoveRotation(CPUrb.rotation * rotate);
        if (Physics.Raycast(transform.position, -Vector3.up, .5f))
        {
            CPUgrounded = true;
        }
        else
        {
            CPUgrounded = false;
        }
    }

    public void Gas()
    {
        if (CPUgrounded)
        {
            if (CPUroughground)
            {
                CPUspeed = CPUspeed + .02f;
                if (CPUspeed > CPUmaxspeed / 3)
                {
                    CPUspeed = CPUmaxspeed / 3;
                }
            }
            else
            {
                CPUspeed = CPUspeed + .02f;
                if (CPUspeed > CPUmaxspeed)
                {
                    CPUspeed = CPUmaxspeed;
                }
            }
        }
    }
}
