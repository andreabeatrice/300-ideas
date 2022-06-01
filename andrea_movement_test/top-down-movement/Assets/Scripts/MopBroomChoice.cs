using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MopBroomChoice : MonoBehaviour
{
    public GameObject mop;
    public GameObject broom;

    public TextMeshProUGUI insanityText;
    public TextMeshProUGUI description;

    public GameObject mopButton;
    public GameObject broomButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        insanityText.text = "insanity: " + Globals.insanity.ToString();
    }

    public void choseMop()
    {
        Globals.inventory.Enqueue("mop");
        mop.SetActive(false);
        Globals.insanity += 0;
        removeButtons();
    }

    public void choseBroom()
    {
        Globals.inventory.Enqueue("broom");
        Globals.insanity += 0;
        broom.SetActive(false);
        removeButtons();
    }

    void removeButtons()
    {
        mopButton.SetActive(false);
        broomButton.SetActive(false);

        //Add insanity info first
        description.text = "Some objects can also be dragged. Try dragging the bucket.";
    }
}
