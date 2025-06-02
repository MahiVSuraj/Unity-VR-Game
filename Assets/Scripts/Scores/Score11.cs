using UnityEngine;

// Import static members of ScoreCount1 class
using static Score10;

public class Score11 : MonoBehaviour
{
    // Static variable to hold the score
    public static int score10;

    // Static constructor to initialize score1 using Score1.score
    static Score11()
    {
        score10 = Score10.score9;
    }

    // Method to increment the score
    public static int IncrementScore()
    {
        ++score10;
        return score10;
        // Debug.Log("Score1: " + score1);
    }
}