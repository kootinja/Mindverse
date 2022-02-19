using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetGameMasterScript : MonoBehaviour
{
    public GameObject row1;
    public GameObject row2;
    public GameObject row3;
    public GameObject row4;
    public GameObject row5;
    public NetGameScript[] netGame;
    public ArrayList board = new ArrayList();
    public static int remainingPieces = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Reset()
    {
        remainingPieces = 25;
        board.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private ArrayList fetchPieces()
    {
        NetGameScript[] netGame = row1.GetComponentsInChildren<NetGameScript>();
        board.Add(netGame);
        netGame = row2.GetComponentsInChildren<NetGameScript>();
        board.Add(netGame);
        netGame = row3.GetComponentsInChildren<NetGameScript>();
        board.Add(netGame);
        netGame = row4.GetComponentsInChildren<NetGameScript>();
        board.Add(netGame);
        netGame = row5.GetComponentsInChildren<NetGameScript>();
        board.Add(netGame);

        return board;
    }

    public void winCheck()
    {
        ArrayList board = new ArrayList();
        board = fetchPieces();
        
        foreach (NetGameScript[] parent in board)
        {
            foreach (NetGameScript child in parent)
            {
                
                if (child.correctPosition == true)
                {
                    remainingPieces--;
                } else if (child.isActive == true)
                {
                    remainingPieces--;
                }
            }
        }

        if (remainingPieces == 0)
        {
            print("You win!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            print("You have: " + remainingPieces.ToString() + " pieces left...");
        }

        Reset();
    }
}
