using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player; 
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // Check if player and scoreText are assigned
        if (player != null && scoreText != null)
        {
            scoreText.text = player.position.z.ToString("0");
        }
        else
        {
            Debug.LogWarning("Player or ScoreText is not assigned in the Inspector.");
        }
    }
}