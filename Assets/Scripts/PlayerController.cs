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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (grounded == true)
        {
            turn = Input.GetAxis("Horizontal");
            if (roughground == true)
            {
                if (Input.GetButton("Fire1"))
                {
                    speed = speed + .02f;
                    if (speed > maxspeed/3)
                    {
                        speed = maxspeed/3;
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
                if (Input.GetButton("Fire1"))
                {
                    speed = speed + .02f;
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
            if (Input.GetAxis("Vertical") < 0)
            {
                speed = speed - .02f;
                if (speed < -1f)
                {
                    speed = -1f;
                }
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
        /*RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, -Vector3.up, .3f);
        for (int i = 0; i < hits.Length; i++)
        {
            grounded = true;
            RaycastHit hit = hits[i];
            if (hit.collider.gameObject.CompareTag("roughground"))
            {
                roughground = true;
            }
            else
            {
                roughground = false;
            }
        }
        if (hits.Length == 0)
        {
            grounded = false;
        }*/


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
        }
     //   Debug.Log("Checkpoint");
    }
}