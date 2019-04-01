using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wakeupfade : MonoBehaviour
{

    public Button button;
    public Image image;

    public void Disappear()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();

        GameObject.Find("Wake_Up").GetComponentInChildren<Text>().text = null;
        Destroy(button);
        Destroy(image);
    }

    /*   private void OnGUI()
       {
           GUI.color = new Color(1, 1, 1, alphaValue);
           if (GUI.Button(new Rect(100, 100, 100, 30), "Wake_Up"))
           {
               clicked = true;
           }
       }*/
}
