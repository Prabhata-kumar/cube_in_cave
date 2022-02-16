using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

    private TextMeshProUGUI scoreText;
    public int score = 0;
    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
  
    public void IncreaseScore(int increment)
    {
        score += increment;
        RefereshUI();
    }

    private void RefereshUI()
    {
        scoreText.text = "Score : " + score;
    }
}
