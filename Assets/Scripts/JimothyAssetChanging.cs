//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Changes Jimothy's icons

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class JimothyAssetChanging : MonoBehaviour
{
    public Sprite JHappy;
    public Sprite JNone;
    public Sprite JMad;
    public Sprite JSad;
    public Sprite JHappyFlipped;
    public Sprite JConfused;

    //public GameObject romanceBar;
    public GameObject heartIcon;

    public Animator animator;

    [YarnCommand("jemote")]
    public void JEmote(string emote)
    {
        if (emote == "happy")
        {
            GetComponent<SpriteRenderer>().sprite = JHappy;
            animator.Play("JimothyBounce");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }

        if (emote == "none")
        {
            GetComponent<SpriteRenderer>().sprite = JNone;
            //romanceBar.SetActive(false);
            heartIcon.SetActive(false);
        }

        if (emote == "mad")
        {
            GetComponent<SpriteRenderer>().sprite = JMad;
            animator.Play("JimothyBounce");
            //romanceBar.SetActive(false);
            heartIcon.SetActive(true);
        }

        if (emote == "sad")
        {
            GetComponent<SpriteRenderer>().sprite = JSad;
            animator.Play("JimothyBounce");
            //romanceBar.SetActive(false);
            heartIcon.SetActive(true);
        }

        if (emote == "flipped")
        {
            GetComponent<SpriteRenderer>().sprite = JHappyFlipped;
            animator.Play("JimothyBounce");
            //romanceBar.SetActive(false);
            heartIcon.SetActive(true);
        }

        if (emote == "confused")
        {
            GetComponent<SpriteRenderer>().sprite = JConfused;
            animator.Play("JimothyBounce");
            //romanceBar.SetActive(false);
            heartIcon.SetActive(true);
        }

    }
}
