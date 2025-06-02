using UnityEngine;

// Import static members of ScoreCount1 class
using static Score2;

public class Score3 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score2;

    // Static constructor to initialize score1 using Score1.score
    static Score3()
    {
        score2 = Score2.score1;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score2;
        return score2;
        // Debug.Log("Score1: " + score1);
    }
}


