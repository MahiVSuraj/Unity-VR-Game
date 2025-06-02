using UnityEngine;

// Import static members of ScoreCount1 class
using static Score4;

public class Score5 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score4;

    // Static constructor to initialize score1 using Score1.score
    static Score5()
    {
        score4 = Score4.score3;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score4;
        return score4;
        // Debug.Log("Score1: " + score1);
    }
}

