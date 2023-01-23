using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AsteroidGameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreUI;
    [SerializeField] private GameObject gameoverUI;

    int score = 0;

    public void AddPoints(int points)
    {
        score += points;
        ScoreUI.text = score.ToString();
    }

    public void SetGameOver()
    {
            gameoverUI.SetActive(true);
    }






}
