using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//GENERIC INTERACT SCRIPT
//Takes OBJECT. (GameObject.Find(""))
//Checks player and object COLLIDERS. (Object.GetComponent?)
//Outputs UI TEXT. (conditional) --> public String message (no need for GameObject text)
//Calls next method if key object. (conditional)

//i.e. open interactive UI (no flavor text) if console
//i.e. prints observe flavour text with no next method if locked door
//i.e. prints observe flavour text and begins dialogue if NPC

public class Interact : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public string message;
    public bool toggle = false;

    void OnGUI()
    {
        GUI.enabled = toggle;
        if (toggle == false)
        {
            GUI.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
        if (toggle == true)
        {
            GUI.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
        GUI.Box(new Rect(0, Screen.height - 100, Screen.width, 100), message);
        GUI.contentColor = Color.white;
        GUI.skin.label.alignment = TextAnchor.UpperLeft;
    }

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
    }

    private float stayCount = 0.0f;

    private void OnTriggerStay(Collider other)
    {
        if (stay)
        {
            stayCount = stayCount + Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                toggle = true;
                Debug.Log("Space pressed.");
            }

            if (stayCount > 0.25f)
            {
                Debug.Log("staying");
                stayCount = stayCount - 0.25f;
            }
            else
            {

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        toggle = false;

        if (exit)
        {
            Debug.Log("exited");
        }
    }

}