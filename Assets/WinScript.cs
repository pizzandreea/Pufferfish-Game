using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
