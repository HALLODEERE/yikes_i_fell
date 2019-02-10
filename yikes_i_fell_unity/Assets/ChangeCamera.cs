using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindObjectOfType<DestroyplaneInFrontOfCam2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cam1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cam2();
        }
    }

    public void Cam1()
    {
        Camera1.enabled = true;
        Camera2.enabled = false;
    }

    public void Cam2()
    {
        Camera2.enabled = true;
        Camera1.enabled = false;
        DestroyplaneInFrontOfCam2.Destroyplane();
    }
}