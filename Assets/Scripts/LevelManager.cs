using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levelPrefabs;
    public static float keepScore;

    private void Awake()
    {
        SpawnLevel(LevelComplete.levelIndex);
        if (LevelComplete.levelIndex == 0)
        {
            PlayerPrefs.SetFloat("Score", 0);
        }
        keepScore = PlayerPrefs.GetFloat("Score");
    }

    private void SpawnLevel(int levelIndex)
    {
        Instantiate(levelPrefabs[levelIndex], levelPrefabs[levelIndex].transform.position, transform.rotation);
    }
}
