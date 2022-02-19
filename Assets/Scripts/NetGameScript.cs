using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetGameScript : MonoBehaviour
{
    public GameObject tile;
    public SpriteRenderer tileColor;
    public bool isActive;
    private object activatedColor = (0, 255, 255);
    private object defaultColor = (63, 106, 54);
    public bool correctPosition;
    public int correctRotation = Convert.ToInt32(null);

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        tile.transform.Rotate(0f, 0f, 90f);
        checkRotation(tile);
    }

    ///<summary>
    ///
    ///If the object sensors are touching one another and one of them are active. Make the other active.
    ///Active objects are turned teal.
    /// </summary>
    private void isActivated(SpriteRenderer tileColor, bool correctPosition)
    {

        if (correctPosition == true)
        {
            isActive = true;
            tileColor.color = Color.cyan;
        }
        else
        {
            isActive = false;
            tileColor.color = new Color(0.2480583f, .4150943f, 0.2134211f);
        }

    }
    ///<summary>
    ///
    ///Checks each tile on the board for the activated color (teal)
    ///If all tile colors are teal then you win and the game is over.
    /// </summary>
    private string winCheck(GameObject board)
    {
        return "You win!";
    }

    private void checkRotation(GameObject tile)
    {
        if(tile.transform.eulerAngles.z == correctRotation)
        {
            correctPosition = true;
        } else
        {
            correctPosition = false;
        }
        //isActivated(tileColor, correctPosition);
    }
}
