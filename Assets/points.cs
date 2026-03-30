using UnityEngine;

public class points : MonoBehaviour
{
    public GameController controller;
    private void Start()
    {
        controller = FindObjectOfType<GameController>();
    }
    void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.score++;
        controller.scoreText.text = "Pontos: " + controller.score.ToString();
        if (controller.score > controller.maxScore)
        {
            controller.maxScore = controller.score; 
            PlayerPrefs.SetInt("MaxScore", controller.maxScore); 
            controller.maxScoreText.text = "Max: " + controller.maxScore.ToString(); 
        }
    }
}
