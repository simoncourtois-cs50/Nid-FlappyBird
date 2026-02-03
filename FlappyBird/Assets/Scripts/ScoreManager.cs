using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int m_score = 0;
    
    public TMP_Text m_scoreText;
    public TMP_Text m_bestScore;
    
    void Start()
    {
        UpdateScore();
        m_bestScore.text = $"Highscore : {GetScore()}";
    }


    public void AddPoint()
    {
        m_score++;
        UpdateScore();
    }

    void UpdateScore()
    {
        m_scoreText.text = $"Score : {m_score}";
        
    }
    public void SaveScore()
    {
        
        int scoreSaved = GetScore();
        if (m_score > scoreSaved)
        {
            PlayerPrefs.SetInt("bestScore", m_score);
        }
        
    }

    private int GetScore()
    {
        return PlayerPrefs.GetInt("bestScore");
    }
}
