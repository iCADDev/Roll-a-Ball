using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float speed;
     private Vector3 moveVector3;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector3 = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
    private void FixedUpdate() 
    {
        if(moveVector3!=Vector3.zero)
        {
            rb.AddForce(moveVector3.normalized * speed);
        }
    }
}
