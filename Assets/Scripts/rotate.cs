using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 currentRot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update(){

        currentRot = GetComponent<Transform>().eulerAngles;

        if ((Input.GetAxis("Horizontal") > .1) && (currentRot.z >= 341 || currentRot.z <= 19)){
            transform.Rotate(0, 0, -0.2f);
        }
        if ((Input.GetAxis("Horizontal") < -.1) && (currentRot.z <= 18 || currentRot.z >= 340)){
            transform.Rotate(0, 0, 0.2f);
        }

        if ((Input.GetAxis("Vertical") < .1) && (currentRot.x >= 341 || currentRot.x <= 19)){
            transform.Rotate(-0.2f, 0, 0);
        }
        if ((Input.GetAxis("Vertical") > -.1) && (currentRot.x <= 18 || currentRot.x >= 340)){
            transform.Rotate(0.2f, 0, 0);
        }
    }
}
