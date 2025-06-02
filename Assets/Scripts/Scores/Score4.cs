using UnityEngine;

// Import static members of ScoreCount1 class
using static Score3;

public class Score4 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score3;

    // Static constructor to initialize score1 using Score1.score
    static Score4()
    {
        score3 = Score3.score2;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score3;
        return score3;
        // Debug.Log("Score1: " + score1);
    }
}
