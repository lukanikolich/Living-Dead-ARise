using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public void GameOver()
    {
        PersonalBestData data = SaveSystem.LoadPersonalBest();
        if (data != null)
        {
            if (data.score < Score.score)
            {
                SaveSystem.SavePersonalBest(Score.score, DateTime.Now);
            }
        } else
        {
            SaveSystem.SavePersonalBest(Score.score, DateTime.Now);
        }
        SceneManager.LoadScene("GameOver");
    }

    public void RestartGame()
    {
        Score.score = 0;
        SceneManager.LoadScene("Menu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

}
