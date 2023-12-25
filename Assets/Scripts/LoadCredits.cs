//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Yarn script to load credits

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Yarn.Unity;

public class LoadCredits : MonoBehaviour
{
    public Animator animator;
    private IEnumerator coroutine;

    [YarnCommand("credits")]
    public void LoadCreditsScene()
    {
        animator.Play("FadeIn");
        StartCoroutine("Waiting");


    }

    private IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("EndCredits");
    }
}
