using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
    public void YesButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void NoButton()
    {
        Debug.Log("Quitted Game.");
        SceneManager.LoadScene("Menu");
    }
}
