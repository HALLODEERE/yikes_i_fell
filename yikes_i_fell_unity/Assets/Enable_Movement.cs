using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_Movement : MonoBehaviour
{

    private MovementScript ms;

    // Start is called before the first frame update
    void Start()
    {
        ms = GetComponent<MovementScript>();
        ms.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Wake_Up"))
        {

            ms.enabled = true;
        }
    }
}
