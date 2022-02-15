using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Path0DialogueOptionChoice1; //Path 0 is the initial dialogue
    public GameObject Path0DialogueOptionChoice2;
    public GameObject Path0DialogueOptionChoice3;

    public GameObject Path1DialogueOptionChoice1;
    public GameObject Path1DialogueOptionChoice2;
    public GameObject Path1DialogueOptionChoice3;

    //public GameObject Path2DialogueOptionChoice1;
    //public GameObject Path2DialogueOptionChoice2;
    //public GameObject Path2DialogueOptionChoice3;

    public int ChoiceMade;

    public void Path0DialogueChoiceOption1() //Path 1 Starts
    {
        TextBox.GetComponent<Text>().text = "You find your phone under the desk, buzzing with two notifications: MISSED CALL – MOM. VOICEMAIL – MOM. ";
        ChoiceMade = 1; //path variable number
    }
    public void Path1DialogueChoiceOption1() //if select first option from path 1, the Lone NPC replies this. 
    {
        TextBox.GetComponent<Text>().text = "His thoughts is that this world could've been better and you serving a greater purpose to a story that can't manifest here.";
        ChoiceMade = 4;
    }

    public void Path0DialogueChoiceOption2() // Path 2 starts
    {
        TextBox.GetComponent<Text>().text= "You walk over to the teacher’s desk. It was mostly cleared off, but there were still a number of papers here and there. You don’t know how your stuff couldn’t ended up here, especially since you couldn’t remember class, but you figure it’s worth a shot. ";
        ChoiceMade = 2;
    }
    public void Path2DialogueChoiceOption2() //if select first option from path 2, the Lone NPC replies this. 
    {
        TextBox.GetComponent<Text>().text = "Read it?";
        ChoiceMade = 7;
    }

    public void Path0DialogueChoiceOption3() // Path 3 starts
    {
        TextBox.GetComponent<Text>().text = "Nothing to say? You must be confused aren't you.";
        ChoiceMade = 3;
    }

    // Update is called once per frame
    void Update()
    {   
        if (ChoiceMade == 0)
        {
            Path0DialogueOptionChoice1.SetActive(true); 
            Path0DialogueOptionChoice2.SetActive(true); //activation and deactivation of options when pressed
            Path0DialogueOptionChoice3.SetActive(true);
            Path1DialogueOptionChoice1.SetActive(false);
            Path1DialogueOptionChoice2.SetActive(false);
            Path1DialogueOptionChoice3.SetActive(false);
        }
        if (ChoiceMade == 1)
        {
            Path1DialogueOptionChoice1.SetActive(true);
            Path1DialogueOptionChoice2.SetActive(true);
            Path1DialogueOptionChoice3.SetActive(true);
            Path0DialogueOptionChoice1.SetActive(false);
            Path0DialogueOptionChoice2.SetActive(false);
            Path0DialogueOptionChoice3.SetActive(false);
        }


       

    }
}

