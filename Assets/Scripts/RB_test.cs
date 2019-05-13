using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_test : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
        if(Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(new Vector3(0, 0, 10) * Time.deltaTime, ForceMode.VelocityChange);
        } else if(Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(new Vector3(0, 0, -10) * Time.deltaTime, ForceMode.VelocityChange);
        } else if(Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(new Vector3(10, 0, 0) * Time.deltaTime, ForceMode.VelocityChange);
        }else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(new Vector3(-10, 0, 0) * Time.deltaTime, ForceMode.VelocityChange);
        }

    }
}
