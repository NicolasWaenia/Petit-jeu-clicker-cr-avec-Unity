using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void AddScore()
    {
        Debug.Log("Bouton cliqué !");
        score++;
        scoreText.text = "Score : " + score;
    }

    public void ResetScore()
    {
        Debug.Log("Score réinitialisé !");
        score = 0;
        scoreText.text = "Score : 0";
    }
}
