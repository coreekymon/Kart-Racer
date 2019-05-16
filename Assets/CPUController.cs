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
        if (CPUgrounded == false)
        {
            NoGas();
        }
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

    public void NoGas()
    {
        if (CPUspeed > .02)
        {
            CPUspeed = CPUspeed - .02f;
        }
        if (CPUspeed >= -.01f && CPUspeed <= .02f)
        {
            CPUspeed = 0;
        }
        if (CPUspeed < -.01f)
        {
            CPUspeed = CPUspeed + .01f;
        }
    }

    public void Reverse()
    {
        CPUspeed = CPUspeed - .02f;
        if (CPUspeed < -1f)
        {
            CPUspeed = -1f;
        }
    }

    public void ResetSpeed()
    {
        CPUmaxspeed = 3;
    }
    public void ControlDisable()
    {
        CPUcontrolEnabled = false;
    }
    public void ResetPosition()
    {
        CPUspeed = 0;
        CPUturn = 0;
        transform.position = CPUposReset + new Vector3(0, 10, 0);
        transform.rotation = CPUrotReset;
    }
    public void LeftTurn()
    {
        CPUturn = -1;
    }
    public void RightTurn()
    {
        CPUturn = 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("roughground"))
        {
            CPUroughground = true;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            CPUspeed = -CPUspeed / 2;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("roughground"))
        {
            CPUroughground = false;
        }
    }
}
