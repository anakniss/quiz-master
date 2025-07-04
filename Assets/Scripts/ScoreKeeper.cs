using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionSeen = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionSeen()
    {
        return questionSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionSeen++;
    }

    public void ResetScore()
    {
        correctAnswers = 0;
        questionSeen = 0;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionSeen * 100);
    }
}
