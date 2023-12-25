//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Toggles pause menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
        }
    }

    public void OnResumeClick()
    {
        pausePanel.SetActive(false);
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }

    public void OnMainMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
