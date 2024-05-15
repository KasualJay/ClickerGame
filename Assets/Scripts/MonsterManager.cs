using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public GameObject[] monsterPrefabs;
    public Monster curMonster;
    public Transform canvas;
    public static MonsterManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Spawn Animal

    public void SpawnMonster()
    {
        GameObject monsterToSpawn = monsterPrefabs[Random.Range(0, monsterPrefabs.Length)];
        GameObject obj = Instantiate(monsterToSpawn, canvas);

        curMonster = obj.GetComponent<Monster>();
    }

    // Replace Monster
    public void ReplaceMonster(GameObject monster)
    {
        Destroy(monster);
        SpawnMonster();
    }
}
