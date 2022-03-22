using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMockScript : MonoBehaviour
{
    public void win()
    {
        Outcome.GameOutcome = true;
        SceneManager.LoadScene("L2S12a", LoadSceneMode.Single);
    }

    public void lose()
    {
        Outcome.GameOutcome = false;
        SceneManager.LoadScene("L2S12a", LoadSceneMode.Single);
    }
}
