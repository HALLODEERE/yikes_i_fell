using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractConsole : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public string message;
    //public bool toggle = false;
    //public GameObject text;
    private GameObject canvas;

    /*void OnGUI()
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
        GUI.Box(new Rect(100, 100, Screen.width-200, Screen.height-200), message);
        GUI.contentColor = Color.white;
        GUI.skin.label.alignment = TextAnchor.UpperLeft;
    }*/

    private void Start()
    {
        canvas = GameObject.Find("ConsoleCanvas");
        canvas.GetComponent<Canvas>().enabled = false;
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
                //toggle = true;
                canvas.GetComponent<Canvas>().enabled = true;
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
        canvas.GetComponent<Canvas>().enabled = false;
        //toggle = false;

        if (exit)
        {
            Debug.Log("exited");
        }
    }

}
