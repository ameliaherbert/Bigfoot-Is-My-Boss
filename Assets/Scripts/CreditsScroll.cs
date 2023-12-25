//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Animates credits

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScroll : MonoBehaviour
{
    public Animator animator;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        animator.Play("FadeAnim");
        animator.Play("Credits");
        StartCoroutine("Waiting");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Waiting()
    {
        yield return new WaitForSeconds(5);
        animator.Play("FadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");
    }

}
