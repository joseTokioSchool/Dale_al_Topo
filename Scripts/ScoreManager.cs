using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManagerInstance;

    [SerializeField] public int score;
    [SerializeField] TMP_Text scoreText;

    private void Awake()
    {
        scoreManagerInstance = this;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}