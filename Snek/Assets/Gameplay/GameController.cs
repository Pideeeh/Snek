using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Overall Manager for game, keeping track of score and resetting the game
public class GameController : MonoBehaviour
{
    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            ScoreText.text = "Score: " + Score;
        }
    }

    public Text ScoreText;
    private int score;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}