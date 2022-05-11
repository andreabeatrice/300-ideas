using UnityEngine;
using System.Collections;

public class ClickCounter : MonoBehaviour
{

    int counter = 0;

    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 200, 50), "COUNTER: " + counter);
        {
        }
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            counter++;
    }
}