using UnityEngine;

// Import static members of ScoreCount1 class
using static Score5;

public class Score6 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score5;

    // Static constructor to initialize score1 using Score1.score
    static Score6()
    {
        score5 = Score5.score4;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score5;
        return score5;
        // Debug.Log("Score1: " + score1);
    }
}
