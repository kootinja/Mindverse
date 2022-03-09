using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultipleChoice : MonoBehaviour
{
    private DialogueController dialogueController;
    public GameObject choiceContainer;
    public GameObject dialogueContainer;
    public GameObject subchoiceContainer;

    public Image choiceButton1;
    public Image choiceButton2;
    public Image choiceButton3;

    public int ChoiceMade;
    private bool MultiChoice = false;
    public int Choice1Value;
    public int Choice2Value;
    public int Choice3Value;

    public List<string> choice1Sentences;
    public List<string> choice2Sentences;
    public List<string> choice2aSentences;
    public List<string> choice2bSentences;
    public List<string> choice3Sentences;
    public List<string> transitionalSentences;

    private void Start()
    {
        dialogueController = GetComponent<DialogueController>();
    }

    public void ChoiceOption1()
    {
        ChoiceMade += Choice1Value;
        choiceContainer.SetActive(false);
        startChoiceDialogue(choice1Sentences);
        choiceButton1.color = new Color(0.4745098f, 0.6078432f, 0.6078432f, 0.772549f);
    }

    public void ChoiceOption2()
    {
        ChoiceMade += Choice2Value;
        MultiChoice = true;
        choiceContainer.SetActive(false);
        startChoiceDialogue(choice2Sentences);
        choiceButton2.color = new Color(0.4745098f, 0.6078432f, 0.6078432f, 0.772549f);
    }

    public void ChoiceOption3()
    {
        ChoiceMade += Choice3Value;
        choiceContainer.SetActive(false);
        startChoiceDialogue(choice3Sentences);
        choiceButton3.color = new Color(0.4745098f, 0.6078432f, 0.6078432f, 0.772549f);
    }

    public void SubChoice1()
    {
        subchoiceContainer.SetActive(false);
        startChoiceDialogue(choice2aSentences);
    }

    public void SubChoice2()
    {
        subchoiceContainer.SetActive(false);
        startChoiceDialogue(choice2bSentences);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startChoiceDialogue(List<string> dialogue)
    {
        dialogueController.Sentences = dialogue;
        dialogueContainer.SetActive(true);
        dialogueController.StartDialogue();
    }

    /// <summary>
    /// Override method for DialogueController.NextSentence
    /// Use this method when you are returning to a choice selection screen
    /// </summary>
    public void NextSentence()
    {

        dialogueController.nextButton.SetActive(false);

        if (dialogueController.Index < dialogueController.Sentences.Count)
        {
            dialogueController.DialogueText.text = string.Empty;
            StartCoroutine(dialogueController.WriteSentence());
        }
        else
        {
            if (ChoiceMade == 6)
            {
                ChoiceMade++;
                dialogueController.DialogueText.text = string.Empty;
                startChoiceDialogue(transitionalSentences);
            } else if (ChoiceMade > 6)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else
            {
                dialogueController.DialogueText.text = string.Empty;

                    if (MultiChoice)
                    {
                        if (subchoiceContainer != null)
                        {
                            subchoiceContainer.SetActive(true);
                        }
                        MultiChoice = false;
                    }
                    else
                    {
                        choiceContainer.SetActive(true);
                    }
                dialogueContainer.SetActive(false);
            }
        }
    }


}
   