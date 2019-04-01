using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PROBABLY UNNECESSARY DUE TO TOGGLE SCRIPT BEING UNNECESSARY!!!!!!!!!!!!!!!!!!!!!!

public class DoorScriptToggle : MonoBehaviour
{
    //Animator CellDoor;
    public DoorScript doorScriptOnToggle;

    // Start is called before the first frame update
    void Start()
    {
        /*CellDoor = cellDoor1.GetComponent<>();
        CellDoor.SetTrigger("Open Door");*/
        //GetComponent<DoorScript>.open
        doorScriptOnToggle.Open();

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.O)) CellDoor.SetTrigger("Open Door");
        if (Input.GetKeyDown(KeyCode.P)) CellDoor.SetTrigger("Close Door");*/
        //CellDoor.SetTrigger("Open Door");
        doorScriptOnToggle.Open();
    }
}
