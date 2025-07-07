using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score = 0;
    public Text scoreTest;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void AddScore(int points)
    {
        score += points;
        scoreTest.text= "Score : "+ score.ToString();
    }

}
