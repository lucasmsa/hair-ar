using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AboutScript : MonoBehaviour
{
    public void BackToMenu() 
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}