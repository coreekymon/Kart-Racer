using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0f;
    private float turn = 0f;
    public Rigidbody rb;
    public bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        turn = Input.GetAxis("Horizontal");
        if (grounded == true)
        {
            if (Input.GetButton("Fire1"))
            {
                speed = speed + .01f;
                if (speed > 1.2)
                {
                    speed = 1.2f;
                }
            }
            if (!Input.GetButton("Fire1"))
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
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            grounded = false;
        }
    }
}
