using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    public Player player01;
    public Player player02;

    public void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }

    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public int Add(float num1, float num2)
    {
        float result = num1 + num2;
        return result
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }

    public int Max(int num1, int num2)
    {
        if(num1 > num2)
        {
            return num1;
        }

        return num2;
    }

    public void Divide(int num1, int num2, ref int result1, ref int result2)
    {
        if(num2 == 0)
        {
            Debug.Log("나누려는 값이 0이기 때문에 프로그램 종료");
            return;
        }

        result1 = num1 / num2;
        result2 = num1 % num2;
    }

    public void Swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    public void Swapref(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    public void Sum(params int[] nums)
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        Debug.Log($"합계: {sum}");
    }

    public void Player(string ID, int health)
    {
        Debug.Log($"ID: {ID}, HP: {health}");
    }

    public void Player(string ID, int health = 1000)
    {
        Debug.Log($"ID: {ID}, HP: {health}");
    }

    private void Awake()
    {

        Multiple(3, 4);

        Add(1, 2);

        int a = 3, b = 4;, result1 = 0; result2 = 0;
        Debug.Log($"Before a = {a}, b = {b}");
        Swap(a, b);
        Debug.Log($"After a = {a}, b = {b}");

        Debug.Log($"Before a = {a}, b = {b}");
        Swapref(a, b);
        Debug.Log($"After a = {a}, b = {b}");

        Divide(a, b, ref result1, ref result2);
        Debug.Log($"몫 = {result1}, 나머지 = {result2}");

        
    }
}
