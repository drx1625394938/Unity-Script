using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public float speed = 3.0f;
    public float turnspeed = 10;

    Animator animator;
    Rigidbody rb;

    float forwardAmount;
    float turnAmount;


    void Start() 
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    Vector3 move;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //��������move����
         move = new Vector3(x, 0, z);
        //תΪ�ֲ�����
        Vector3 localmove = transform.InverseTransformVector(move);
        forwardAmount = localmove.z;
        turnAmount = Mathf.Atan2(localmove.x, localmove.z);

        if (Input.GetButton("Fire3")) 
        {
            forwardAmount *= 0.3f;
        }

       //transform.LookAt(transform.position + new Vector3(x, 0, z));//����
       //transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;
        animUpdate();
    }
    private void FixedUpdate()
    {
        rb.velocity = forwardAmount *transform.forward* speed;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, turnAmount * turnspeed, 0));
    }

    void animUpdate() 
    {
       // animator.SetFloat("speed", move.magnitude);
        animator.SetFloat("forward", forwardAmount);
        animator.SetFloat("speed", turnAmount);
    }
}
