using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleChoice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;
    
    public void ChoiceOption1 () {
        TextBox.GetComponent<Text>().text = "You find your phone under the desk, buzzing with two notifications: MISSED CALL – MOM. VOICEMAIL – MOM. You click on the notification and your mother’s soft voice echoes in the empty classroom. Mom: Hey, sweetie. I know you’re probably hanging out with your friends after school, but can you please make sure to grab some milk on the way home? Thanks! The voicemail ends and you glance around.  ";
        ChoiceMade = 1;
    }

    public void ChoiceOption2 () {
        TextBox.GetComponent<Text>().text = "You walk over to the teacher’s desk. It was mostly cleared off, but there were still a number of papers here and there. You don’t know how your stuff couldn’t ended up here, especially since you couldn’t remember class, but you figure it’s worth a shot. *sound of papers rustling* After messing around with the papers, you find a letter written in by the teacher… addressed to your mother of all people.";
        ChoiceMade = 2;
    }

    public void ChoiceOption3 () {
        TextBox.GetComponent<Text>().text = "You go to the coat rack near the door, noting that the janitor was humming some odd tune just a ways away. Shaking your head, you go through the myriad of coats on the hooks, looking for your own. In no time you find it and reach into the pockets, pulling out half of a key. You: Why…?You let out a frustrated huff. Just what were you supposed to do with half of a key? But you remember the janitor is waiting, so you turn back to the classroom. You’ll figure it out later.";
        ChoiceMade = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(ChoiceMade >= 1) {
            Choice01.SetActive (false);
            Choice01.SetActive (false);
            Choice01.SetActive (false);
        }
    }
}
