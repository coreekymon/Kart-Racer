using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0f;
    public float maxspeed = 3f;
    private float turn = 0f;
    public Rigidbody rb;
    public bool grounded = false;
    public bool roughground = false;
    public Vector3 posReset;
    public Quaternion rotReset;
    public bool controlEnabled = false;
    public float acceleration = .015f;
    public bool racestart = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posReset = transform.position;
        rotReset = transform.rotation;
        rb.centerOfMass = new Vector3(0, -.6f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (controlEnabled)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                speed = 0;
                turn = 0;
                transform.position = posReset + new Vector3(0, 10, 0);
                transform.rotation = rotReset;
            }
            if (grounded == true)
            {
                turn = Input.GetAxis("Horizontal");
                if (roughground == true)
                {
                    if (Input.GetButton("Fire1") && Input.GetAxis("Vertical") >= 0)
                    {
                        speed = speed + acceleration;
                        if (speed > maxspeed / 3)
                        {
                            speed = maxspeed / 3;
                        }
                    }
                    if (!Input.GetButton("Fire1"))
                    {

                        if (speed > .02)
                        {
                            speed = speed - .02f;
                        }
                        if (speed >= -.01f && speed <= .02f)
                        {
                            speed = 0;
                        }
                        if (speed < -.01f)
                        {
                            speed = speed + .01f;
                        }
                    }
                }
                else
                {
                    if (Input.GetButton("Fire1") && Input.GetAxis("Vertical") >= 0)
                    {
                        speed = speed + acceleration;
                        if (speed > maxspeed)
                        {
                            speed = maxspeed;
                        }
                    }
                    if (!Input.GetButton("Fire1"))
                    {

                        if (speed > .02)
                        {
                            speed = speed - .02f;
                        }
                        if (speed >= -.01f && speed <= .02f)
                        {
                            speed = 0;
                        }
                        if (speed < -.01f)
                        {
                            speed = speed + .01f;
                        }
                    }
                }
                if (Input.GetAxis("Vertical") < 0 && speed > 0)
                {
                    speed = speed - .04f;
                    if (speed < -1f)
                    {
                        speed = -1f;
                    }
                }
                if (Input.GetAxis("Vertical") < 0 && speed <= 0)
                {
                    speed = speed - .02f;
                    if (speed < -1f)
                    {
                        speed = -1f;
                    }
                }
                if(Input.GetButton("Fire1") && speed < 0 && Input.GetAxis("Vertical") >= 0)
                {
                    speed = speed + .04f;
                }
            }
            if (grounded == false)
            {
                if (speed > .01)
                {
                    speed = speed - .01f;
                }
                if (speed > 0 && speed < .01)
                {
                    speed = 0;
                }
            }
        }
        else
        {
            turn = 0;
            if (speed > .04f)
            {
                speed = speed - .04f;
            }
            if (speed < -.04f)
            {
                speed = speed + .04f;
            }
            if (speed > -.04f && speed < .04f)
            {
                speed = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * speed);
        Quaternion rotate = Quaternion.Euler(0f, turn * 45f * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * rotate);
        if(Physics.Raycast(transform.position, -Vector3.up, .5f))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        if (!grounded)
        {
            rb.AddForce(-Vector3.up*25);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("roughground"))
        {
            roughground = true;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            speed = -speed/2;
        }
      
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("roughground"))
        {
            roughground = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Boost Item"))
        {
            other.gameObject.SetActive(false);
            maxspeed = maxspeed * 2f;
            speed = speed * 1.5f;
            if(maxspeed > 5)
            {
                maxspeed = 5;
            }
            Invoke("ResetSpeed", 2f);
        }
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            posReset = other.gameObject.transform.position;
            rotReset = other.gameObject.transform.rotation;
        }
     //   Debug.Log("Checkpoint");
    }
    public void ResetSpeed()
    {
        maxspeed = 3;
    }
    public void ControlDisable()
    {
        controlEnabled = false;
    }
    public void ControlEnable()
    {
        controlEnabled = true;
        racestart = true;
    }
}