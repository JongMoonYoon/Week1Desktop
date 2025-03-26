using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target)
    public void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"체쳑이 {damage}감소");
        }
        else{
            Debug.Log("Die");
        }
    }
}

public class Goblin : Entity
{
    public Goblin(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }

    public override void Attack(Entity target)
    {
        Debug.Log("고블린의 몽둥이 스매시!");
        target.TakeDamage(damage);
    }
}

public class Slime : Entity
{
    public Slime(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }

    public override void Attack(Entity target)
    {
        Debug.Log("슬라임의 몽둥이 스매시!");
        target.TakeDamage(damage);
    }
}