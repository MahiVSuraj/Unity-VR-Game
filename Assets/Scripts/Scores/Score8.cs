using UnityEngine;

// Import static members of ScoreCount1 class
using static Score7;

public class Score8 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score7;

    // Static constructor to initialize score1 using Score1.score
    static Score8()
    {
        score7 = Score7.score6;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score7;
        return score7;
        // Debug.Log("Score1: " + score1);
    }
}