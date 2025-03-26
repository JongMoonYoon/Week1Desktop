using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{
    private void Awake()
    {
        Player player new Player();
        {
            player.ID = "고박사",
            player.currentHP = 100,
        };

        player.SetCurrentHP(100);
        Debug.Log($"Player HP: {player.GetCurrentHP()}");

        player.currentHP = 100;
        Debug.Log($"Player HP: {player.currentHP}");
        player.currentHP = -100;
        Debug.Log($"Player HP: {player.currentHP}");

        player.ID = "고박사";
        player.currentHP = 100;
        Debug.Log($"{player.ID} HP: {player.currentHP}");

        Player2 player2 = new Player2()
        {
            player2.ID = "고박사",
            player2.Shield = 50,
            player2.Defense = 10,
        };

        Debug.Log($"ID: {player2.ID}");
        Debug.Log($"방어력: {player2.Defense}, 방어막: {player.Shield}");
    }
}

public class Player
{
    private int currentHP;
    public int GetCurrentHP() {return currentHP;}
    public void SetCurrentHP(int hp) {currentHP = hp;}

    public int currentHP
    {
        get => currentHP;
        set
        {
            if(currentHP > 0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
        }
    }

    public int currentHP
    {
        private get;set;
    }

    public string ID
    {
        get;set;
    }
}

interface IBaseEntity
{
    string ID {get; set;}
    int Damage {get; set;}
    int CurrentHP {get; set;}
}

public class Player1 : IBaseObject
{
    private string id;
    public string ID
    {
        get => id;
        set => id = value;
    }
    public int Damage
    {
        get;set;
    }
    public int CurrentHP
    {
        get;set;
    }
}

public abstract class BaseEntity
{
    abstract public int Shield
    {
        get;set;
    }
    public int Defense
    {
        get;set;
    }
}

public class Player2 : BaseEntity
{
    public override int Shield
    {
        get;set;
    }
    public int ID
    {
        get;set;
    }
}