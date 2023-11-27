using UnityEngine;
using UnityEngine.UI;

public class variables : MonoBehaviour
{
    [SerializeField] private Text ScoreText;
    [SerializeField] private Text TotalTimeText;
    [SerializeField] private Text FinalScoreText;
    [SerializeField] private AudioSource Subtract;
    public int CurrentScore;
    public int SavedScore;
    public float TotalTime = 0;
    public float TotalTimeTemp = 0;
    public int AdCount = 0;


    public void ScoreUpdate1()
    {
        CurrentScore += 1;
        ScoreText.text = CurrentScore.ToString();
    }

    public void ScoreUpdate10()
    {
        CurrentScore += 10;
        ScoreText.text = CurrentScore.ToString();
    }

    public void ScoreSubtract10()
    {
        CurrentScore -= 10;
        ScoreText.text = CurrentScore.ToString();
        Subtract.Play();
    }

    public void SetSavedScore()
    {
        SavedScore = CurrentScore;
        ScoreText.text = CurrentScore.ToString();
    }

    public void RestoreScoreAfterDeath()
    {
        CurrentScore = SavedScore;
        ScoreText.text = CurrentScore.ToString();
    }

    public void FinalScoreBoard()
    {
        FinalScoreText.text = CurrentScore.ToString();
        TotalTimeText.text = TotalTime.ToString("0");
    }
}
