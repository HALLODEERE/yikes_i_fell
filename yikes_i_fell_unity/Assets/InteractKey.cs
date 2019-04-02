using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractKey : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public string message;
    public bool toggle = false;
    //public GameObject keycoll;
    public GameObject text;

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
        /*keycoll = GameObject.Find("Key").GetComponent<GameObject>();
        keycoll.GetComponent<Text>().enabled = false;*/
        text = GameObject.Find("pickupText");
        text.GetComponent<Text>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        text.GetComponent<Text>().enabled = true;
        //keycoll.GetComponent<Text>().enabled = true;
    }

    private float stayCount = 0.0f;

    private void OnTriggerStay(Collider other)
    {
        if (stay)
        {
            stayCount = stayCount + Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                /*Text flav = transform.gameObject.AddComponent<Text>();
                flav.color = Color.white;
                flav.alignment = TextAnchor.UpperLeft;
                flav.fontSize = 10;
                //flav.transform.SetParent(transform);
                flav.text = message;*/
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
            //keycoll.GetComponent<Text>().enabled = false;
            text.GetComponent<Text>().enabled = false;
            Debug.Log("exited");
        }
    }

}
