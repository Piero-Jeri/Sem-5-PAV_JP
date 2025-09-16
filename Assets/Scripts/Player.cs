using UnityEngine;

public class Player
{
    public int life = 10;

    public Player(int _life)
    {
        life = _life;
    }

    public static Player operator +(Player a, Player b)
    {
        return new Player(a.life + b.life);
    }
    public static Player operator /(Player a, int x)
    {
        return new Player(a.life / x);
    }
    public static bool operator ==(Player a, Player b)
    {
        return a.life == b.life;
    }
    public static bool operator !=(Player a, Player b)
    {
        return a.life != b.life;
    }
    public static Player operator -(Player a, Player b)
    {
        return new Player(a.life - b.life);
    }
    public static Player operator *(Player a, int x)
    {
        return new Player(a.life * x);
    }
    public static Player operator *(Player a, Player b)
    {
        return new Player(a.life * b.life);
    }
    public static bool operator <(Player a, Player b)
    {
        return a.life < b.life;
    }
    public static bool operator >(Player a, Player b)
    {
        return a.life > b.life;
    }

}
