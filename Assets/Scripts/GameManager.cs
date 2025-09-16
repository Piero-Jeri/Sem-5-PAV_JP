using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player1 = new(10);
    public Player player2 = new(10);

    public Npc npc1;
    public Npc npc2;
    public Npc npc3;

    void Start()
    {
        Player player3 = player1 + player2;
        Player player4 = player2 / 2;
        Player player5 = player1 * player2;

        print(player1 = player2);
        print(player3 > player2);


        npc1 = new Npc("Marco", Emotion.Sad, "hola caraon con cola");
        npc2 = new Npc("Marco", Emotion.Sad, "hola caraon con cola");
        npc3 = new Npc("Marco", Emotion.Sad, "hola caraon con cola");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            npc1.Talk("Zuricatita");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            npc2.Talk("lolo", Emotion.Angry);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            npc3.Talk("Tecsup coach", Emotion.Angry, "nadie me usa");
        }
    }
    //https://github.com/sowTecsup/S5PAV_JN
}
