using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameEnd = false;

    public GameObject completeUI;

    public void CompleteLevel()
    {
        completeUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            FindObjectOfType<Score>().scoreText.text = "YOU DIED";
            Invoke("Restart", 4f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
