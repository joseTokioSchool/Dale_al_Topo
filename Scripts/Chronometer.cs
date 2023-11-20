using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Chronometer : MonoBehaviour 
{
    [SerializeField] TMP_Text chronoText;
    [SerializeField] public float chronometer;

    [SerializeField] GameObject endGamePanel;

    void Start()
    {
        //chronometer = 10;  
        endGamePanel.SetActive(false);
    }
    void Update()
    {
        if (chronometer > 0)
        {
            chronometer -= Time.deltaTime;
            chronoText.text = chronometer.ToString("F0");
        }
        else if (chronometer < 0)
        {
            chronometer = 0;
            chronoText.text = chronometer.ToString();
            Time.timeScale = 0f;
            endGamePanel.SetActive(true);
        }
    }
    public void RestartGame()
    {
        ScoreManager.scoreManagerInstance.score = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu(int n)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(n);
    }
}
