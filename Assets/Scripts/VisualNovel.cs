using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using Yarn.Unity;

public class VisualNovel : MonoBehaviour
{
    //[SerializeField] CharacterList characterList;
    private Dictionary<string, Character> characters = new Dictionary<string,Character>();
    private DialogueRunner dialogueRunner;
    //private FadeOverlay fadeOverlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        //fadeOverlay = FindObjectOfType<FadeOverlay>();

        //dialogueRunner.AddCommandHandler<Location>("camera", ChangeCameraLocation);

        dialogueRunner.AddCommandHandler<string, string>("place", PlaceCharacter);

        //dialogueRunner.AddCommandHandler<float>("fadeIn", FadeIn);
        //dialogueRunner.AddCommandHandler<float>("fadeOut", FadeOut);
    }

    private void PlaceCharacter(string characterName, string markerName)
    {
        Character character;

        if (!characters.ContainsKey(characterName))
        {
            //var characterPrefab = characterList.FindCharacterPrefab(characterName);
            //character = Instantiate(characterPrefab);
            //characters[characterName] = character;
        }
        else
        {
            character = characters[characterName];
        }
        var marker = GameObject.Find(markerName);
        //character.transform.position = marker.transform.position;
        //character.transform.rotation = marker.transform.rotation;
    }

}
