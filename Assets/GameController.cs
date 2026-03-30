using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public int maxScore;
    public Text maxScoreText;
    private void Start()
    {
        Time.timeScale = 1;
        maxScore = PlayerPrefs.GetInt("MaxScore", 0);
        maxScoreText.text = "Max: " + maxScore.ToString();
        scoreText.text = "Pontos: ";
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
