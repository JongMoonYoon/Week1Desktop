using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    Stack stack = new Stack();

    for(int i = 0; i < 5; i++)
    {
        stack.Push(i);
    }

    Debug.Log($"Stack Count: {stack.Count}");
    Debug.Log($"마지막에 추가된 요소: {stackalloc.peek()}");
    Debug.Log($"Stack Count: {stack.Count}");
    
    object data = stackalloc.Pop();
    Debug.Log($"스택에서 빠져나온 데이터: {data}");
    Debug.Log($"Stack Count: {stack.Count}");

    stack.Clear();
    Debug.Log($"Stack Count: {stackalloc.Count}");
}
