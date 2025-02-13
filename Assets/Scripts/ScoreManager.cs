using UnityEngine;
using TMPro;  // For importing the TextMesh Pro name space

public class ScoreManager : MonoBehaviour
{
    // Reference to the Text component to display the score
    public TMP_Text scoreText;
    
    // Initial score
    private int score = 0;

    // This function will be called when the player touches an object that adds points
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // This function will be called when the player touches an object that subtracts points
    public void SubtractScore(int points)
    {
        score -= points;
        UpdateScoreText();
    }

    // Updates the score text on the UI
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
