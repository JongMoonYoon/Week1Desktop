using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashtableExercise : MonoBehaviour
{
    private void Awake()
    {
        Hashtable hash = new Hashtable();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        hash["Goblin"] = goblin;      

        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요. 고박사입니다.", "문자열");

        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        } 

        if(hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime 키 존재");
        }

        if(hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} 값 존재");
        }

        Debug.Log($"Hashtable Count: {hash.Count}");

        hash.Remove("Slime");

        Debug.Log($"Hashtable Count: {hash.Count}");

        hash.Clear();

        Debug.Log($"Hashtable Count: {hash.Count}");
    }
}

public class Goblin{ }

public class Slime{ }
