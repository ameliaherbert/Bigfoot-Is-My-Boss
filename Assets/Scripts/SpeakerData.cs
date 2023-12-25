using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialog/Speaker")]
public class SpeakerData : ScriptableObject
{

    public const string EMOTION_CHATTING = "MCChatting";
    public const string EMOTION_JUDGEMENTAL = "MCJudgemental";

    public string speakerName;
    public Sprite MCChatting, MCJudgemental;

    public Sprite GetEmotion(string emotion)
    {
        switch (emotion)
        {
            default:
            case EMOTION_CHATTING: return MCChatting;
            case EMOTION_JUDGEMENTAL: return MCJudgemental;
        }
    }

}
