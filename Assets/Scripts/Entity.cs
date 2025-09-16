using UnityEngine;

public class Entity
{
    public int health;

    //-> constructor

    public void GetDamage(int x)
    {
        health -= x;
    }
    public void GetDamage(int x, float crit)
    {
        bool isCritic = Random.Range(0, 100) < crit;
        if(isCritic == true)
        {
            int FinalDamage = x*2;
            x = FinalDamage;
        }
        health -= x;
    }
    public void GetDamage(int x, float crit, bool knockback)
    {

    }
}