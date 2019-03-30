using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingTerminalScreen : MonoBehaviour
{
    public Renderer rend;
    public int debugMode = 1;
    public float timeBetweenBlink = 0.5f;
    public int i = 69;

    /*IEnumerator screenBlink() //should enable renderer for the black screen, wait for a second, then disable it...repeat indefinitely
    {
        while (i == 69)
        {
            rend.enabled = true;
            yield return new WaitForSeconds(timeBetweenBlink);
            rend.enabled = false;
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rend.enabled = false;
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            rend.enabled = true;
        }
        /*while (i == 69)
        {
            screenBlink();
        }*/
        //StartCoroutine(screenBlink());
    }
}
