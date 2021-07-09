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
    public GameObject die;
    private PlayerMovement _playerMovement;
    private Score _score;

    private void Awake()
    {
        _score = FindObjectOfType<Score>();
        _playerMovement = FindObjectOfType<PlayerMovement>();
    }

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
            _playerMovement.enabled = true;
        }   
        else if (!isStart)
            _playerMovement.enabled = false;

        levelCounter.text = "LEVEL: " + (LevelComplete.levelIndex + 1);
    }

    public void CompleteLevel()
    {
        completeUI.SetActive(true);
        _playerMovement.forwardForce = 0;
        _playerMovement.prb.velocity = Vector3.zero;
    }

    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            _score.scoreText.enabled = false;
            die.SetActive(true);
            Invoke("Restart", 4f);
            LevelComplete.levelIndex = 0;
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
