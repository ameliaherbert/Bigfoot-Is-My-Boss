//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Loads menu after tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class TutorialEnd : MonoBehaviour
{
    [YarnCommand("menu")]
    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
