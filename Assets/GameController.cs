using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySpace;

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child();
        c.Method01();

        Parent pc = new Child();
        pc.Method01();

        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "고박사";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"{player01.ID}, 체력: {player01.currentHP}, 공경력: {player01.damage}");
        Debug.Log($"{player02.ID}, 체력: {player02.currentHP}, 공경력: {player02.damage}");

        var a = {"고박사", 35};
        Debug.Log($"{a.Item1}, {a.Item2}");

        a.Itme2 = 36;
        Debug.Log($"{a.Item1}, {a.Item2}");

        var b = (Name:"고박사", Age:35);
        Debug.Log($"{a.Name}, {a.Age}");

        var(name, age) = b;
        Debug.Log($"{name}, {age}");

        var c = (Name:"고박사", Age:35);
        var(name_) = c;

        Enemy enemy01 = new Enemy();
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        Enemy.specise = "고블린";
        Debug.Log(Enemy.specise);

        Debug.Log(Calculator.Sum(20, 55));
        Debug.Log(Calculator.num);

        string str = "안녕하세요. 고박사입니다.";
        str.PrintData();
    }
}

public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}

public class Child : Parent
{
    public new void Method01()
    {
        Debug.Log("child");
    }
}

public class Entity
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity: {damage}만큼 체력 감소");
    }
}

public class MovingEntity : Entity
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity: {damage}만큼 체력 감소");
    }
}

public class Player : MovingEntity
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity: {damage}만큼 체력 감소");
    }
}

public partial class Player
{
    public void CounterAttack()
    {

    }
}

public partial class Player
{
    public void TakeDamage(int damage)
    {
        CounterAttack();
    }
}

public struct Stats
{
    public string ID;
    public int currentHP;
    public int damage;
}

public class Enemy
{
    public int numeric;
    public static string specise;

    public int InstanceRun()
    {
        return 1;
    }

    public static int StaticRun()
    {
        return 1;
    }
}

public static class Calculator
{
    public static int num;

    static Calculator()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

public static class StringExtension
{
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}

namespace MySpace
{
    public class Player
    {

    }
}

namespace YourSpace
{
    public class Player
    {

    }
}