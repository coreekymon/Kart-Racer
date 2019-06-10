using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public int helditem = 0;
    public bool giant = false;
    public bool ATV = false;
    public Text item;
    public Rigidbody laser;
    public Transform laserspawn;
    public int lasercount = 0;
    public Rigidbody mine;
    public Transform minespawn;
    public AudioSource source;
    public AudioSource sfx;
    public float lerpvalue = 0f;
    public AudioClip lasersfx;
    public AudioClip minesfx;
    public AudioClip crash;
    public AudioClip getitem;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        posReset = transform.position;
        rotReset = transform.rotation;
        rb.centerOfMass = new Vector3(0, -.6f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(source != null)
        {
            lerpvalue = Mathf.Abs(speed / 3);
            if(lerpvalue > 1)
            {
                lerpvalue = 1;
            }
            source.pitch = Mathf.Lerp(.3f, 2f, lerpvalue);
        }
        if (controlEnabled)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                Useitem();
            }
            if (Input.GetButtonDown("Fire2"))
            {
                ResetPosition();
            }
            if (grounded == true)
            {
                turn = Input.GetAxis("Horizontal");
                if (roughground == true && ATV == false)
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
            sfx.PlayOneShot(crash, .7f);
            speed = -speed/2;
        }
        if (collision.gameObject.CompareTag("Crash"))
        {
            sfx.PlayOneShot(crash, .7f);
            if (giant == false)
            {
                speed = -speed / 2;
            }
            if (giant == true)
            {
                speed = speed + .5f;
            }
        }
        if (collision.gameObject.CompareTag("Mine"))
        {
            ResetPosition();
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
            sfx.PlayOneShot(getitem, .7f);
            other.gameObject.SetActive(false);
            helditem = Random.Range(1, 6);
            if (helditem == 1)
            {
                item.text = "Item: Speed";
            }
            if (helditem == 2)
            {
                item.text = "Item: Giant";
            }
            if (helditem == 3)
            {
                item.text = "Item: ATV";
            }
            if (helditem == 4)
            {
                lasercount = 5;
                item.text = "Item: Laser";
            }
            if(helditem == 5)
            {
                item.text = "Item: Mine";
            }
        }
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            posReset = other.gameObject.transform.position;
            rotReset = other.gameObject.transform.rotation;
        }
     //   Debug.Log("Checkpoint");
    }
    public void Useitem()
    {
        if(helditem == 0)
        {
            return;
        }
        if(helditem == 1)
        {
            maxspeed = maxspeed * 2f;
            speed = speed * 1.5f;
            if (maxspeed > 5)
            {
                maxspeed = 5;
            }
            Invoke("ResetSpeed", 2f);
            helditem = 0;
            item.text = "Item: None";
        }
        if(helditem == 2 && giant == false)
        {
            giant = true;
            maxspeed = maxspeed * 1.5f;
            rb.MovePosition(Vector3.up);
            transform.localScale = transform.localScale * 2;
            if (maxspeed > 5)
            {
                maxspeed = 5;
            }
            Invoke("ResetSpeed", 6f);
            Invoke("ResetScale", 6f);
            helditem = 0;
            item.text = "Item: None";
        }
        if (helditem == 3)
        {
            ATV = true;
            Invoke("ResetATV", 10f);
            helditem = 0;
            item.text = "Item: None";
        }
        if (helditem == 4)
        {
            Instantiate(laser, laserspawn.position, laserspawn.rotation);
            sfx.PlayOneShot(lasersfx, .7f);
            lasercount = lasercount - 1;
            if (lasercount == 0)
            {
                helditem = 0;
                item.text = "Item: None";
            }
        }
        if (helditem == 5)
        {
            Instantiate(mine, minespawn.position, minespawn.rotation);
            sfx.PlayOneShot(minesfx, .7f);
            helditem = 0;
            item.text = "Item: None";
        }
    }
    public void ResetPosition()
    {
        speed = 0;
        turn = 0;
        transform.position = posReset + new Vector3(0, 10, 0);
        transform.rotation = rotReset;
    }
    public void ResetSpeed()
    {
        maxspeed = 2.5f;
    }
    public void ResetScale()
    {
        transform.localScale = new Vector3(1,1,1);
        giant = false;
    }
    public void ResetATV()
    {
        ATV = false;
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