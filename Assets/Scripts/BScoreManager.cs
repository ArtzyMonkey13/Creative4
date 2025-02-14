using UnityEngine;
using TMPro;  // For importing the TextMesh Pro name space

public class BScoreManager : MonoBehaviour
{
    // Reference to the Text component to display the score
    public TMP_Text scoreText;

    // Initial score
    private int score = 0;

    // This function will be called when the player touches an object that adds points
    public void BAddScoreObject(int points)
    {
        score += points;
        Debug.Log("Score after addition: " + score); // Debug log to check the score after addition
        UpdateScoreText();
    }

    // This function will be called when the player touches an object that subtracts points
    public void BSubtractScoreObject(int points)
    {
        score -= points;
        Debug.Log("Score after subtraction: " + score); // Debug log to check the score after subtraction
        UpdateScoreText();
    }

    // Updates the score text on the UI
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}

