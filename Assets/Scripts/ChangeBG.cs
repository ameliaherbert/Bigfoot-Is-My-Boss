//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Fade and change background

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class ChangeBG : MonoBehaviour
{
    public Sprite None;
    public Sprite Office;
    public Sprite Restaurant;
    public Sprite Breakroom;
    public Sprite Closet;
    public Sprite Cubicles;
    public Sprite Elevator;
    public Sprite Forest;
    public Sprite Street;
    public Sprite RiverScene;
    public Sprite MeetingRoom;
    public Sprite JOffice;
    public Sprite Aquarium;
    public Sprite AmusementPark;

    public float FadeOutTime = 1f;
    public float FadeInTime = 1f;
    private bool visible = false;

    //while alpha is less than 1, fade bg in
    IEnumerator DoFadeIn( SpriteRenderer _sprite)
    {
        Color tmpColor = _sprite.color;
        float startTime = Time.time;

        //While time continues, fade color
        while(tmpColor.a < 1f)
        {
            tmpColor.a = Mathf.Lerp(0f, 1f, (Time.time - startTime) / FadeOutTime);
            _sprite.color = tmpColor;

            yield return null;
            
        }
        visible = true;
        _sprite.color = tmpColor;

    }


    //fade bg out if alpha
    IEnumerator DoFadeOut(SpriteRenderer _sprite)
    {
        Color tmpColor = _sprite.color;
        float startTime = Time.time;
        float tmp;

        while (tmpColor.a > 0f)
        {
            tmp = Mathf.Lerp(0f, 1f, (Time.time - startTime) / FadeInTime);
            tmpColor.a = 1f - tmp;
            _sprite.color = tmpColor;

            yield return null;
        }

        visible = false;
        _sprite.color = tmpColor;

    }

    //background switching
    IEnumerator doBGFade(string bg)
    {

        StartCoroutine(DoFadeOut(GetComponent<SpriteRenderer>()));

        yield return new WaitForSeconds(.5f);

        visible = false;

        if (bg == "none")
        {
            GetComponent<SpriteRenderer>().sprite = None;
        }
        if (bg == "office")
        {
            GetComponent<SpriteRenderer>().sprite = Office;
        }
        if (bg == "restaurant")
        {
            GetComponent<SpriteRenderer>().sprite = Restaurant;
        }
        if (bg == "breakroom")
        {
            GetComponent<SpriteRenderer>().sprite = Breakroom;
        }
        if (bg == "closet")
        {
            GetComponent<SpriteRenderer>().sprite = Closet;
        }
        if (bg == "cubicles")
        {
            GetComponent<SpriteRenderer>().sprite = Cubicles;
        }
        if (bg == "elevator")
        {
            GetComponent<SpriteRenderer>().sprite = Elevator;
        }
        if (bg == "forest")
        {
            GetComponent<SpriteRenderer>().sprite = Forest;
        }
        if (bg == "street")
        {
            GetComponent<SpriteRenderer>().sprite = Street;
        }
        if (bg == "river")
        {
            GetComponent<SpriteRenderer>().sprite = RiverScene;
        }
        if (bg == "meetingRoom")
        {
            GetComponent<SpriteRenderer>().sprite = MeetingRoom;
        }

        if (bg == "jOffice")
        {
            GetComponent<SpriteRenderer>().sprite = JOffice;
        }

        if (bg == "aquarium")
        {
            GetComponent<SpriteRenderer>().sprite = Aquarium;
        }

        if (bg == "amusementPark")
        {
            GetComponent<SpriteRenderer>().sprite = AmusementPark;
        }

        StartCoroutine(DoFadeIn(GetComponent<SpriteRenderer>()));

        yield return new WaitForSeconds(.5f);

        visible = true;
    }


    //starts coroutine for bg fade
    [YarnCommand("background")]
    public void ChangeBackground(string bg)
    {

        StartCoroutine(doBGFade(bg));
        
    }
}
