using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Physics.gravity = new Vector3(0, 5, 0);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate()
    {
        //float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(Input.acceleration.x, Input.acceleration.y, -Input.acceleration.z);
        rb.AddForce(movement * speed);
    }
}
