//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Change and animate Protag's icons

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ProtagChanging : MonoBehaviour
{
    public Sprite ProtagHappy;
    public Sprite ProtagFrightened;
    public Sprite ProtagNone;
    public Sprite ProtagConfused;
    public Sprite ProtagSad;
    public Sprite ProtagFlustered;
    public Sprite ProtagMad;
    public GameObject heartIcon;

    public Animator animator;
    public void SetTrigger(string trigger_bounce) { }


    //changes MC's emote, plays animation on change, sets heart icon to active
    [YarnCommand("pemote")]
    public void ProtagEmote(string emote)
    {
        if (emote == "happy")
        {
            GetComponent<SpriteRenderer>().sprite = ProtagHappy;
            animator.Play("ProtagBounceAnimation");

            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }
        if (emote == "frightened")
        {
            GetComponent<SpriteRenderer>().sprite = ProtagFrightened;
            animator.Play("ProtagBounceAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }
        if (emote == "none")
        {
            GetComponent<SpriteRenderer>().sprite = ProtagNone;
            animator.Play("ProtagBounceAnimation");
            //romanceBar.SetActive(false);
            heartIcon.SetActive(false);
        }

        if (emote == "confused")
        {
            GetComponent<SpriteRenderer>().sprite = ProtagConfused;
            animator.Play("ProtagBounceAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }

        if (emote == "sad")
        {
            GetComponent<SpriteRenderer>().sprite = ProtagSad;
            animator.Play("ProtagBounceAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }

        if (emote == "flustered")
        {
            GetComponent<SpriteRenderer>().sprite = ProtagFlustered;
            animator.Play("ProtagBounceAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }

        if (emote == "mad")
        {
            GetComponent<SpriteRenderer>().sprite = ProtagMad;
            animator.Play("ProtagBounceAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }

    }
}
