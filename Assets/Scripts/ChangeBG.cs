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

    // While alpha is less than 1, fade bg (background) in
    IEnumerator DoFadeIn( SpriteRenderer _sprite)
    {
        Color tmpColor = _sprite.color;
        float startTime = Time.time;

        // While time continues, fade alpha
        while (tmpColor.a < 1f)
        {
            // Assuming a value from 0 to 1 in small incrememnts as time changes
            tmpColor.a = (Time.time - startTime) / FadeOutTime;
            _sprite.color = tmpColor;

            yield return null;
        }
        visible = true;
        _sprite.color = tmpColor;
    }


    // Fade bg out if alpha
    IEnumerator DoFadeOut(SpriteRenderer _sprite)
    {
        Color tmpColor = _sprite.color;
        float startTime = Time.time;

        while (tmpColor.a > 0f)
        {
            // Assuming a value from 1 to 0 in small incrememnts as time changes
            tmpColor.a = 1.0f - (Time.time - startTime) / FadeOutTime;
            _sprite.color = tmpColor;

            yield return null;
        }
        visible = false;
        _sprite.color = tmpColor;
    }

    // Background switching
    IEnumerator doBGFade(string bg)
    {
        StartCoroutine(DoFadeOut(GetComponent<SpriteRenderer>()));

        yield return new WaitForSeconds(0.5f);

        visible = false;

        if (bg == "none") {
            GetComponent<SpriteRenderer>().sprite = None;
        } else if (bg == "office") {
            GetComponent<SpriteRenderer>().sprite = Office;
        } else if (bg == "cubicles") {
            GetComponent<SpriteRenderer>().sprite = Cubicles;
        } else if (bg == "elevator") {
            GetComponent<SpriteRenderer>().sprite = Elevator;
        } else if (bg == "forest") {
            GetComponent<SpriteRenderer>().sprite = Forest;
        } else if (bg == "street") {
            GetComponent<SpriteRenderer>().sprite = Street;
        } else if (bg == "river") {
            GetComponent<SpriteRenderer>().sprite = RiverScene;
        } else if (bg == "meetingRoom") {
            GetComponent<SpriteRenderer>().sprite = MeetingRoom;
        } else if (bg == "jOffice") {
            GetComponent<SpriteRenderer>().sprite = JOffice;
        } else if (bg == "aquarium") {
            GetComponent<SpriteRenderer>().sprite = Aquarium;
        } else if (bg == "amusementPark") {
            GetComponent<SpriteRenderer>().sprite = AmusementPark;
        }

        StartCoroutine(DoFadeIn(GetComponent<SpriteRenderer>()));

        yield return new WaitForSeconds(0.5f);

        visible = true;
    }

    // Starts coroutine for bg fade
    [YarnCommand("background")]
    public void ChangeBackground(string bg)
    {
        StartCoroutine(doBGFade(bg));
    }
}