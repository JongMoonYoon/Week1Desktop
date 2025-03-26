using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdvanced : MonoBehaviour
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }

    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }

    public void Heal()
    {
        Debug.Log("체력을 회복한다.");
    }

    private int damage = 10;

    public void Hit(Goblin goblin)
    {
        goblin.TakeDamage(damage);
    }

    public void Hit(Slime slime)
    {
        slime.TakeDamage(damage);
    }

    public void Hit(Dragon dragon)
    {
        dragon.TakeDamage(damage);
    }

    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(damage);
    }

    private Entity goblin;
    private Entity slime;

    void Awake()
    {
        Enemy enemy = new Slime();
        if(enemy is Slime)
        {
            Debug.Log("Enemy type is Slime");
        }

        Goblin goblin = entity as Goblin;
        if(goblin == null)
        {
            Debug.Log("goblin is null");
        }

        goblin = new Goblin(5, 100);
        slime = new Slime(10, 50);

        goblin.Attack(slime);
        slime.Attack(goblin);
    }
}

public class Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"적: {damage}만큼 체력 감소");
    }
}

public class Goblin : Enemy
{
    public void Avoid()
    {
        Debug.Log("도망가자!");
    }

    public void Heal()
    {
        Debug.Log("고블린의 체력 회복!");
    }

    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린: {damage}만큼 체력 감소");
    }
}

public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임: {damage}만큼 체력 감소");
    }
}

public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤: {damage}만큼 체력 감소")
    }
}