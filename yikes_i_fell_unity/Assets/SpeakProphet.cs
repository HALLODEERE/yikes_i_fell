using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeakProphet : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public int i;
    public string[] messages;
    public bool toggle = false;
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
        i = 0;
        GUI.Box(new Rect(0, Screen.height - 100, Screen.width, 100), "Prophet: " + messages[i]);
        //GUI.contentColor = Color.green;
        GUI.skin.label.alignment = TextAnchor.UpperCenter;
    }

    private void Start()
    {
        messages = new string[3];
        messages[0] = "Oh. Hello there... I wasn't expecting company. \n\n\n YOU'VE REACHED THE END OF THIS DEMO.";
        //messages[1] = "I  wasn't expecting company.";
        //messages[2] = "You've reached the end of this demo.";
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
                //i++;
                Debug.Log("Space pressed.");
            }

            if (stayCount > 0.25f)
            {
                Debug.Log("staying");
                stayCount = stayCount - 0.25f;
            }
            else
            {
                i = 0;
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
