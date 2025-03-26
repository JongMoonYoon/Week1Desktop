using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ClassAdvanced
{
    private string ID;

    private int currentHP;

    public void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
        }
    }

    void RecoveryHP(int hp)
    {
        currentHP += hp;
    }

    public Player()
    {
        ID = "고박사";
    }

    public Player(int hp): this()
    {
        base.ID = "고박사";
        currentHP = hp;
    }

    ~Player()
    {

    }

    public SetID(string ID)
    {
        Debug.Log($"ID: {ID}");
        Debug.Log($"ID: {this.ID}");
    }


}
