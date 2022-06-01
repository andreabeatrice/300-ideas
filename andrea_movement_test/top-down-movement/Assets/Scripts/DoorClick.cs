using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorClick : MonoBehaviour
{

    private float startposx;
    private float startposy;
    //private bool isBeingHeld = false;
    Vector3 mousepos;

    // Update is called once per frame
    void Update()
    {
       /* if (isBeingHeld == true)
        {
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);

            
            //this.gameObject.transform.localPosition = new Vector3(mousepos.x, mousepos.y, 0);
        }*/
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("test");
            SceneManager.LoadScene(1);

        }
    }

    private void OnMouseUp()
    {
        //isBeingHeld = false;
    }
}
