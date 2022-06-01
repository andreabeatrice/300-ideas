using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReceptionistClick : MonoBehaviour
{
    public Dialogue dialog;

    public Queue<string> sentences;

    public Text nameText;

    public Text dialogText;

    public GameObject textBox;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        textBox.SetActive(false);
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textBox.SetActive(true);
            StartDialogue(dialog);

           

            //Change scene
            //isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        //isBeingHeld = false;
    }

    public void StartDialogue(Dialogue di)
    {
        sentences.Clear();

        nameText.text = di.name;

        foreach(string sentence in di.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;


    }

    void EndDialogue()
    {

    }
}
