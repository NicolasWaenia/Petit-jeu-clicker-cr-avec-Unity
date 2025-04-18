using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void AddScore()
    {
        Debug.Log("Bouton cliqu� !");
        score++;
        scoreText.text = "Score : " + score;
    }

    public void ResetScore()
    {
        Debug.Log("Score r�initialis� !");
        score = 0;
        scoreText.text = "Score : 0";
    }
}
