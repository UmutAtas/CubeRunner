using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;
    public static float storeScore;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        storeScore = LevelManager.keepScore;
    }
    void Update()
    {
        if (_gameManager.gameEnd == false)
        {
            storeScore += playerTransform.position.z/100;
            scoreText.text = storeScore.ToString("0");
        }
    }
}
