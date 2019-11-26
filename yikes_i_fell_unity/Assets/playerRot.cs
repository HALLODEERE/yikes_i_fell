using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRot : MonoBehaviour
{

    //public Rigidbody rb;
    public float rotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 dir = rb.velocity;
        //transform.rotation = Quaternion.LookRotation(dir);

            float rotation = (Input.GetAxis("Horizontal")+Input.GetAxis("Vertical")/2) * rotationSpeed - 0.2f;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
    }
}
