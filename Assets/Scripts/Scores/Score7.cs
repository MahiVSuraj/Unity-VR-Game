using UnityEngine;

// Import static members of ScoreCount1 class
using static Score6;

public class Score7 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score6;

    // Static constructor to initialize score1 using Score1.score
    static Score7()
    {
        score6 = Score6.score5;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score6;
        return score6;
        // Debug.Log("Score1: " + score1);
    }
}
