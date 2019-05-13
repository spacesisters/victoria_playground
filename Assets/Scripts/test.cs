using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Vector3 pos;
    public float speed = 10f;
    private Vector3 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zDir = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        moveVector = new Vector3(xDir, 0, zDir);
        transform.Translate(moveVector);
    }
}
