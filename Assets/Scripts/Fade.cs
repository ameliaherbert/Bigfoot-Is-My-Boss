//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Plays fade animation

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class Fade : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand ("FadeOut")]
    public void FadeOut()
    {
        animator.Play("Fade");
    }
}
