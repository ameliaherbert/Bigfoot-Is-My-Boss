//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Updates heart icons

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class HeartIcon : MonoBehaviour
{
    public int currentValue;
    public Sprite Zero;
    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite None;

    public GameObject heartIcon;

    private void Start()
    {
        currentValue = 0;
    }

    public void TakeRomance(int add)
    {
        currentValue += add;

    }

    [YarnCommand("heart")]
    public void HeartUp(int value)
    {
        currentValue += value;
        Heart(currentValue);
    }



    public void Heart(int value)
    {
        if (currentValue == -2)
        {
            GetComponent<SpriteRenderer>().sprite = Zero;
        }
        if (currentValue == -1)
        {
            GetComponent<SpriteRenderer>().sprite = One;
        }
        if (currentValue == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Two;
        }
        if (currentValue == 1)
        {
            GetComponent<SpriteRenderer>().sprite = Three;
        }
        if (currentValue == 2)
        {
            GetComponent<SpriteRenderer>().sprite = Four;
        }
        if (currentValue == 3)
        {
            GetComponent<SpriteRenderer>().sprite = Five;
        }
        if (currentValue == 10)
        {
            GetComponent<SpriteRenderer>().sprite = None;
        }
    }
}