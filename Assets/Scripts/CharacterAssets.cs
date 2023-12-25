using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class CharacterAssets : MonoBehaviour
{

    public SpriteRenderer Character;
    public Sprite MCJudgemental;

    public void Start()
    {
        //GameObject go1 = new GameObject();
        //go1.name = "go1";
        //go1.AddComponent(typeof());
    }

    [YarnCommand("judgy")]
    public void Judgy(SpriteRenderer localName)
    {
        print("working");
        Character.sprite = MCJudgemental;
    }
}
