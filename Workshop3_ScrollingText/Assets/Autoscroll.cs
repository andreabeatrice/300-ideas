using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Autoscroll : MonoBehaviour
{
    float speed = 100.0f;
    //float textPosBegin = -707.0f;
    float boundaryTextEnd = 4044.0f;

    RectTransform myGORectTransform;
    [SerializeField]
    TextMeshProUGUI mainText;

   // [SerializeField]
   // bool isLooping = false; 

    // Start is called before the first frame update
    void Start()
    {
        myGORectTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(AutoScrollText());

    }

    IEnumerator AutoScrollText()
    {
        while(myGORectTransform.localPosition.y < boundaryTextEnd)
        {
            myGORectTransform.Translate(Vector3.up * speed * Time.deltaTime);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            counter++;


        if (counter >= 10)
        {
            speed = 40.0f;

            StartCoroutine(SlowDownPowerUp());
        }
        

        
    }

    IEnumerator SlowDownPowerUp()
    {
        yield return new WaitForSecondsRealtime(5);
        counter = 0;
        speed = 100.0f;
    }

    int counter = 0;

    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 200, 50), "COUNTER: " + counter);
        {
        }
    }


}
