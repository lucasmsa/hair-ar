using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartButton() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void AboutButton()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
