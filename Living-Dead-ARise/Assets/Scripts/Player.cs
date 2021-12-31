using UnityEngine;

public class Player : MonoBehaviour
{

    private GameManager gameManager;

    private void Start()
    {
        GameObject gameManagerObject = GameObject.Find("GameManager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("zombie"))
        {
            gameManager.GameOver();
        }
    }
}
