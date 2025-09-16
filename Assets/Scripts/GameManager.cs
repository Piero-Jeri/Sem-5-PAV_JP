using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player1 = new(10);
    public Player player2 = new(10);
    void Start()
    {
        Player player3 = player1 + player2;
        Player player4 = player2 / 2;
        Player player5 = player1 * player2;

        print(player1 = player2);
        print(player3 > player2);
    }

    void Update()
    {
        
    }
    //https://github.com/sowTecsup/S5PAV_JN
}
