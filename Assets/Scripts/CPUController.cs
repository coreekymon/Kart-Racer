using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUController : MonoBehaviour
{
    public float CPUspeed = 0f;
    public float CPUmaxspeed = 3f;
    private float CPUturn = 0f;
    public float CPUacceleration = .015f;
    public Rigidbody CPUrb;
    public bool CPUgrounded = false;
    public bool CPUroughground = false;
    public Vector3 CPUposReset;
    public Quaternion CPUrotReset;
    public bool CPUcontrolEnabled = false;
    public bool forward = false;
    public bool slightleft = false;
    public bool slightright = false;
    public bool hardleft = false;
    public bool hardright = false;
    public bool reverse = false;
    public int behaviortype = 0;
    public float resetcounter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        CPUrb = GetComponent<Rigidbody>();
        CPUposReset = transform.position;
        CPUrotReset = transform.rotation;
        CPUrb.centerOfMass = new Vector3(0, -.6f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        resetcounter = resetcounter + Time.deltaTime;
        if (CPUcontrolEnabled)
        {
            if(behaviortype == 0)
            {
                EfficientBehavior();
            }
            if(behaviortype == 1)
            {
                SharpTurnBehavior();
            }
        }
        else
        {
            NoGas();
            NoGas();
        }
        if(resetcounter > 20)
        {
            ResetPosition();
            resetcounter = 0;
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
        if (!CPUgrounded)
        {
            CPUrb.AddForce(-Vector3.up * 50);
        }
    }

    public void Gas()
    {
        if (CPUgrounded)
        {
            if (CPUroughground)
            {
                CPUspeed = CPUspeed + CPUacceleration;
                if (CPUspeed > CPUmaxspeed / 3)
                {
                    CPUspeed = CPUmaxspeed / 3;
                }
            }
            else
            {
                CPUspeed = CPUspeed + CPUacceleration;
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
        CPUspeed = CPUspeed - .04f;
        if (CPUspeed < -1f)
        {
            CPUspeed = -1f;
        }
    }
    public void ResetTimer()
    {
        resetcounter = 0;
    }
    public void ResetSpeed()
    {
        CPUmaxspeed = 2.5f;
    }
    public void ControlDisable()
    {
        CPUcontrolEnabled = false;
    }
    public void ControlEnable()
    {
        CPUcontrolEnabled = true;
    }
    public void ResetPosition()
    {
        CPUspeed = 0;
        CPUturn = 0;
        transform.position = CPUposReset + new Vector3(0, 10, 0);
        transform.rotation = CPUrotReset;
    }
    public void HardLeftTurn()
    {
        CPUturn = -1;
    }
    public void HardRightTurn()
    {
        CPUturn = 1;
    }
    public void SlightLeftTurn()
    {
        CPUturn = -.5f;
    }
    public void SlightRightTurn()
    {
        CPUturn = .5f;
    }
    public void NoTurn()
    {
        CPUturn = 0f;
    }
    public void Brake()
    {
        if(CPUspeed > 0)
        {
            CPUspeed = CPUspeed - .04f;
            if (CPUspeed < .5f)
            {
                CPUspeed = .5f;
            }
        }
    }
    public void Boost()
    {
        CPUmaxspeed = CPUmaxspeed * 2f;
        CPUspeed = CPUspeed * 1.5f;
        if (CPUmaxspeed > 5)
        {
            CPUmaxspeed = 5;
        }
        Invoke("ResetSpeed", 2f);
    }

    public void EfficientBehavior()
    {
        if (!CPUgrounded)
        {
            NoGas();
        }
        else
        {
            if (forward)
            {
                NoTurn();
                Gas();
            }
            if (slightleft)
            {
                SlightLeftTurn();
                Gas();
            }
            if (slightright)
            {
                SlightRightTurn();
                Gas();
            }
            if (reverse)
            {
                NoTurn();
                Reverse();
            }
            if (hardleft)
            {
                HardLeftTurn();
                Gas();
            }
            if (hardright)
            {
                HardRightTurn();
                Gas();
            }
            if(!forward && !reverse && !slightleft && !slightright && !hardleft && !hardright)
            {
                NoGas();
            }
        }
    }

    public void SharpTurnBehavior()
    {
        if (!CPUgrounded)
        {
            NoGas();
        }
        else
        {
            if (forward)
            {
                NoTurn();
                Gas();
            }
            if (slightleft)
            {
                SlightLeftTurn();
                Gas();
            }
            if (slightright)
            {
                SlightRightTurn();
                Gas();
            }
            if (reverse)
            {
                NoTurn();
                Reverse();
            }
            if (hardleft)
            {
                HardLeftTurn();
                Brake();
            }
            if (hardright)
            {
                HardRightTurn();
                Brake();
            }
            if (!forward && !reverse && !slightleft && !slightright && !hardleft && !hardright)
            {
                NoGas();
            }
        }
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
