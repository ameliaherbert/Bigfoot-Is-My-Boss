//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Buttons for main menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void OnStartClick()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnTutorialClick()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }
}
