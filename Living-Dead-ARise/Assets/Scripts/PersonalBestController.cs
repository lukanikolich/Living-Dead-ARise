using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonalBestController : MonoBehaviour
{
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        PersonalBestData data = SaveSystem.LoadPersonalBest();
        scoreText.text = data != null ? "Personal best: " + data.score : "Personal best: 0";
    }
}
