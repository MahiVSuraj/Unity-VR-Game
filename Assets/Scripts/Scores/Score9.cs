using UnityEngine;

// Import static members of ScoreCount1 class
using static Score8;

public class Score9 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score8;

    // Static constructor to initialize score1 using Score1.score
    static Score9()
    {
        score8 = Score8.score7;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score8;
        return score8;
        // Debug.Log("Score1: " + score1);
    }
}