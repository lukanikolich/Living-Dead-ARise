using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class
    GameOverScreen : MonoBehaviour
{
    public Text numOfKillsText;

    public void Setup(int numOfKills)
    {
        gameObject.SetActive(true);
        if (numOfKills == 1)
        {
            numOfKillsText.text = "You killed " + numOfKills.ToString() + " zombie";
        }
        else
        {
            numOfKillsText.text = "You killed " + numOfKills.ToString() + " zombies";
        }
    }

    public void RestartButon()
    {
        SceneManager.LoadScene("Game");
    }
}
