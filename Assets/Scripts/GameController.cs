using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    ScoreKeeper sk;

    void Start()
    {
        sk = FindObjectOfType<ScoreKeeper>();
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void LoadNextGame()
    {
        sk.SetHighest();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
