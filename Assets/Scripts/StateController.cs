//Amelia Herbert
//2365874
//aherbert@chapman.edu
//CPSC 340-02
//Capstone
//Changes characters locations on screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class StateController : MonoBehaviour
{
    public Vector2 LeftSide;
    public Vector2 RightSide;
    public Vector2 Middle;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPosition)
        {
            case Positions.Right:
                GetComponent<Transform>().localPosition = new Vector3(RightSide.x, RightSide.y, 0);
                break;

            case Positions.Left:
                GetComponent<Transform>().localPosition = new Vector3(LeftSide.x, LeftSide.y, 0);
                break;

            case Positions.Middle:
                GetComponent<Transform>().localPosition = new Vector3(Middle.x, Middle.y, 0);
                break;
        }
    }

    public enum Positions
    {
        Right,
        Left,
        Middle
    }

    public Positions currentPosition;

    [YarnCommand("mcposition")]
    public void SwitchPosition(string Position)
    {
        switch (Position)
        {
            case "right":
                currentPosition = Positions.Right;
                break;
            case "left":
                currentPosition = Positions.Left;
                break;
            case "middle":
                currentPosition = Positions.Middle;
                break;
        }
    }

    




}
