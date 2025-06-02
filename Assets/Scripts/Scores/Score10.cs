using UnityEngine;

// Import static members of ScoreCount1 class
using static Score9;

public class Score10 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score9;

    // Static constructor to initialize score1 using Score1.score
    static Score10()
    {
        score9 = Score9.score8;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score9;
        return score9;
        // Debug.Log("Score1: " + score1);
    }
}