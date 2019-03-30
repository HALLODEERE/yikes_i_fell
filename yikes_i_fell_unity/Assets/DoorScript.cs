using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator CellDoor;

    // Start is called before the first frame update
    void Start()
    {
        CellDoor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) CellDoor.SetTrigger("Open Door");
        if (Input.GetKeyDown(KeyCode.P)) CellDoor.SetTrigger("Close Door");
    }
}
