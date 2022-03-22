using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceDependentScript : MonoBehaviour
{
    public DialogueController dialogueController;
    public MultipleChoice multipleChoice;
    public GameObject nextButtonMultiChoice;

    private List<string> Choice1Sentences;
    public List<string> gameLostSentences;
    public List<string> gameWonSentences;
    public List<string> Choice2Sentences;
    public List<string> Choice3Sentences;

    public void Start()
    {
        if (Outcome.ChoseChoice1 == true)
        {
            if (Outcome.GameOutcome == true)
            {
                Choice1Sentences = gameWonSentences;
                if (multipleChoice != null)
                {
                    dialogueController.nextButton.SetActive(false);
                    dialogueController.nextButton = nextButtonMultiChoice;
                    multipleChoice.startChoiceDialogue(Choice1Sentences);
                } else
                {
                    startChoiceDialogue(Choice1Sentences);
                }
            } else
            {
                Choice1Sentences = gameLostSentences;
                startChoiceDialogue(Choice1Sentences);
            }

            Outcome.ChoseChoice1 = false;
        }
        else if (Outcome.ChoseChoice2 == true)
        {
            startChoiceDialogue(Choice2Sentences);
            Outcome.ChoseChoice2 = false;
        } else if (Outcome.ChoseChoice3 == true)
        {
            startChoiceDialogue(Choice3Sentences);
            Outcome.ChoseChoice3 = false;
        } 
    }

    public void startChoiceDialogue(List<string> dialogue)
    {
        dialogueController.Sentences = dialogue;
        dialogueController.StartDialogue();
    }
}
