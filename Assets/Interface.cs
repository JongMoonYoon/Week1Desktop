using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : IMovingEntity, ICombatEntity
{
    private ImovingEntity goblin;
    private ImovingEntity slime;
    private ImovingEntity butterfly;

    public void Move(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }

    public void Attack(Entity target)
    {
        Debug.Log($"{target}을 공격합니다.")
    }

    public void Method(ImovingEntity entity)
    {

    }

    public ImovingEntity Method()
    {
        Goblin goblin = new Goblin();
        return goblin;
    }

    void Awake()
    {
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();

        goblin.MoveTo(new vector3(1, 2, 3));
        slime.MoveTo(new vector3(4, 5, 6));
        butterfly.MoveTo(new vector3(7, 8, 9));

        Method(goblin);

        goblin = Method();

    }
}

interface ImovingEntity
{
    void MoveTo(vector3 destination);
}

interface IMovingEntity
{
    void Move(Vector3 destination);
}

interface ICombatEntity
{
    void Attack(Entity target);
}

public class Goblin : ImovingEntity
{
    public void MoveTo(vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}
