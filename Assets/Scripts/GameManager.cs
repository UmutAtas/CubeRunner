using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameEnd = false;
    public GameObject completeUI;
    public static bool isStart = false;
    public GameObject startText;
    public Text levelCounter;
    public GameObject finishText;

    private void Start()
    {
        isStart = false;
        gameEnd = false;
        if (LevelComplete.levelIndex == 5)
        {
            finishText.SetActive(true);
            isStart = false;
            gameEnd = true;
            startText.SetActive(false);
            levelCounter.gameObject.SetActive(false);
        }
    } 

    private void Update()
    {
        if (isStart && !gameEnd)
        {
            startText.SetActive(false);
            FindObjectOfType<PlayerMovement>().enabled = true;
        }   
        else if (!isStart)
            FindObjectOfType<PlayerMovement>().enabled = false;
        levelCounter.text = "LEVEL: " + (LevelComplete.levelIndex+1).ToString(); 
    }

    public void CompleteLevel()
    {
        completeUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().forwardForce += 5;
    }

    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            FindObjectOfType<Score>().scoreText.text = "YOU DIED";
            Invoke("Restart", 4f);
            LevelComplete.levelIndex = 0;
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
