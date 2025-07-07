using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject rButton;

    public static GameManager instance;
    public void GameOverScreen(bool hasWon)
    {
        if (hasWon)
        {
            winPanel.SetActive(true);
        }
        else
        {
            losePanel.SetActive(true);
        }
        rButton.SetActive(true);
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void RestartG()
    {
        Debug.Log("HelloWorld");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    void Update()
    {
        
    }
}
