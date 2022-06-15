using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitted Game.");
        Application.Quit();
    }

}
