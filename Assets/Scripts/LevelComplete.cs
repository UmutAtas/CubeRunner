using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public static int levelIndex = 0;

    public void LoadNextLevel()
    {
        PlayerPrefs.SetFloat("Score", Score.storeScore);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        levelIndex += 1;
    }
}
