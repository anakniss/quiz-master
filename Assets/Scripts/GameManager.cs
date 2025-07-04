using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Quiz quiz;
    private EndScreen endScreen;

    void Awake()
    {
        quiz = FindObjectOfType<Quiz>(true);
        endScreen = FindObjectOfType<EndScreen>(true);
    }
    
    void Start()
    {
        // quiz.gameObject.SetActive(true);
        // endScreen.gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
