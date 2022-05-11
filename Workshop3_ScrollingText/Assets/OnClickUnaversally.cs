using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This is so that it should find the Text component
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers
using TMPro;

public class OnClickUnaversally : MonoBehaviour, IPointerDownHandler
{ // Extends the pointer handlers
    [SerializeField]
    TextMeshProUGUI unaversally;

    void Start()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        unaversally.color = new Color32(0, 92, 122, 255);
        unaversally.text = "universally";
    }

    
}