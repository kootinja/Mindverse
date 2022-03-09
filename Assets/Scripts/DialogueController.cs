using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public List<string> Sentences;
    public int Index;
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

    public void StartDialogue() {
        Index = 0;
        StartCoroutine(WriteSentence());
    }

    public IEnumerator WriteSentence() 
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

        if(Index < Sentences.Count) 
        {
            DialogueText.text = string.Empty;
            StartCoroutine(WriteSentence());

        } else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    

}
