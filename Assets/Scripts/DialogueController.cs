using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int Index;
    public float DialogueSpeed;
    

    public GameObject nextButton;

    public void Start()
    {
        DialogueText.text = string.Empty;
        StartDialogue();
    }

    public void Update()
    {
        if(DialogueText.text == Sentences[Index]) {
            nextButton.SetActive(true);
        }
    }

    void StartDialogue() {
        Index = 0;
        StartCoroutine(WriteSentence());
    }

    IEnumerator WriteSentence() 
    {
        foreach(char Character in Sentences[Index].ToCharArray()) 
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
    }

    public void NextSentence()
    {

        nextButton.SetActive(false);

        if(Index < Sentences.Length - 1) 
        {
            Index++;
            DialogueText.text = string.Empty;
            StartCoroutine(WriteSentence());

        } else {
            DialogueText.text = "";
            nextButton.SetActive(false);
        }
    }

    

}
