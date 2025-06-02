using UnityEngine;

// Import static members of ScoreCount1 class
using static Score1;

public class Score2 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score1;

    // Static constructor to initialize score1 using Score1.score
    static Score2()
    {
        score1 = Score1.score;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score1;
        return score1;
        // Debug.Log("Score1: " + score1);
    }
}


