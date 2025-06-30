using Unity.VisualScripting;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject quizCanvas;
    public Quiz quiz;
    public Timer timer;
    public EndScreen endScreen;
    public ScoreKeeper scoreKeeper;

    public void BeginQuiz()
    {
        Debug.Log("begin quiz");
        scoreKeeper.ResetScore();
        startCanvas.SetActive(false);
        quizCanvas.SetActive(true);
        timer.CancelTimer();
        timer.isAnsweringQuestion = false;
        quiz.Restart();
        endScreen.gameObject.SetActive(false);
    }

    public void EndQuiz()
    {
        Application.Quit();
    }

    private void OnDisable()
    {
        Debug.Log("start game disable");
    }
}
