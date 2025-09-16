using UnityEngine;

public enum Emotion
{
    None,
    Happy,
    Angry,
    Sad,
    Scared,
    Anxius
}

public class Npc : MonoBehaviour
{
    public string NpcName;
    public Emotion Emotion;
    public string Dialog;

    public void Set(string npcName, Emotion emotion, string dialog)
    {
        NpcName = npcName;
        Emotion = emotion;
        Dialog = dialog;

    }
    public void Talk()
    {
        print("Hola me llamo " + NpcName + "Me siento ... " + Emotion + " Queria decirte que " + Dialog);
    }
    public void Talk(string newNpcName)
    {
        NpcName = newNpcName;
        print("Hola me llamo " + NpcName + "Me siento ... " + Emotion + " Queria decirte que " + Dialog);
    }
    public void Talk(string newNpcName, Emotion newEmotion)
    {
        NpcName = newNpcName;
        Emotion = newEmotion;

        print("Hola me llamo " + NpcName + "Me siento ... " + Emotion + " Queria decirte que " + Dialog);
    }
    public void Talk(string newNpcName, Emotion newEmotion, string newDialog)
    {
        NpcName = newNpcName;
        Emotion = newEmotion;
        Dialog = newDialog;

        print("Hola me llamo " + NpcName + "Me siento ... " + Emotion + " Queria decirte que " + Dialog);
    }
}
