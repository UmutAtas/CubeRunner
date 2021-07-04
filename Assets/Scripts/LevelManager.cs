using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levelPrefabs;

    private void Start()
    {
        SpawnLevel(LevelComplete.levelIndex);
    }

    private void SpawnLevel(int levelIndex)
    {
        Instantiate(levelPrefabs[levelIndex], levelPrefabs[levelIndex].transform.position, transform.rotation);
    }
}
