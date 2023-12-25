//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Change and animate MC's icons

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class CharacterAssetChanging : MonoBehaviour
{
    public Sprite MCJudgy;
    public Sprite MCChatty;
    public Sprite MCNone;
    public Sprite MCBored;
    public Sprite MCMad;
    public Sprite MCWorried;
    public GameObject heartIcon;

    public Animator animator;
    public void SetTrigger(string MCIsBouncing) { }

    //changes MC's emote, plays animation on change, sets heart icon to active
    [YarnCommand("mcemote")]
    public void MCEmote(string emote)
    {
        if (emote == "chatty")
        {
            GetComponent<SpriteRenderer>().sprite = MCJudgy;
            animator.Play("MCBouncingAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }
        if (emote == "judgy")
        {
            GetComponent<SpriteRenderer>().sprite = MCChatty;
            animator.Play("MCBouncingAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }
        if(emote == "none")
        {
            GetComponent<SpriteRenderer>().sprite = MCNone;
            //romanceBar.SetActive(false);
            heartIcon.SetActive(false);
        }
        if (emote == "bored")
        {
            GetComponent<SpriteRenderer>().sprite = MCBored;
            animator.Play("MCBouncingAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }
        if (emote == "mad")
        {
            GetComponent<SpriteRenderer>().sprite = MCMad;
            animator.Play("MCBouncingAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }
        if (emote == "worried")
        {
            GetComponent<SpriteRenderer>().sprite = MCWorried;
            animator.Play("MCBouncingAnimation");
            //romanceBar.SetActive(true);
            heartIcon.SetActive(true);
        }

    }

}
