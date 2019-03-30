using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    public GameObject planeInFrontOfCamera2;
    int debugMode = 0;
    // Start is called before the first frame update

    public void changeTheCamera()
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
        //DestroyplaneInFrontOfCam2.Destroyplane();
        //destroyThePlane10();
    }

    public void rotateTheWalls()
    {
        if (Camera1.enabled == true)
        {
            //planeInFrontOfCamera2.transform.Rotate(0f, 180f, 0f, Space.World);
            planeInFrontOfCamera2.transform.rotation = Quaternion.Euler(0, 180, 90);
            if (debugMode == 1) { Debug.Log("Camera 1 is enabled"); }
        }
        if (Camera2.enabled == true)
        {
            planeInFrontOfCamera2.transform.rotation = Quaternion.Euler(0, 0, 90);
            if (debugMode == 1) { Debug.Log("Camera 2 is enabled"); }
        }
    }

    /*public void destroyThePlane10() //nonfunctional
    {
        Destroy(GameObject.Plane10);
    }*/

    /*public void assignGameObjects() //this will happen eventually
    {
        GameObject Plane10 = GameObject.Find("Plane (10)");
    }*/

    void Start()
    {
        //script = GameObject.FindObjectOfType<DestroyplaneInFrontOfCam2>();
        //GameObject Plane10 = GameObject.Find("Plane (10)");
        Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        changeTheCamera();
        rotateTheWalls();
    }

    
}