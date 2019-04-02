using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractDoor : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public string message;
    public bool toggle = false;
    public GameObject text;
    public Toggle door;

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
        door = GetComponent<Toggle>();
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
     
            else { }

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
