using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    int highest = 0;
    
    public int GetHighest()
    {
        return highest;
    }

    static ScoreKeeper instance;
    void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetHighest()
    {
        if (SceneManager.GetActiveScene().buildIndex > highest && 
            SceneManager.GetActiveScene().name != "Main" && 
            SceneManager.GetActiveScene().name != "Game Over")
        {
            highest = SceneManager.GetActiveScene().buildIndex;
        }
    }
}
