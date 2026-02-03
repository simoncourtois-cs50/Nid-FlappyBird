using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    public GameObject _gameOverMenu;
   
    public enum GameState
    {
        Playing,
        GameOver,
        Restart
    };

    public static GameState currentGameState;
    private int _score;
    private void Start()
    {
        currentGameState = GameState.Playing;
    }
    
    public void Update()
    {
        switch (currentGameState)
        {
            case GameState.GameOver:
                //Game Over
                SaveScore();
                Time.timeScale = 0f;
                _gameOverMenu.SetActive(true);
                break;
            
            case GameState.Playing:
                //Playing
                break;
            
            case GameState.Restart:
                Time.timeScale = 1.0f;
                SceneManager.LoadScene("Game");
                break;
                
        }
    }

    private void SaveScore()
    {
        _score = FindFirstObjectByType<ScoreManager>().score;
        int scoreSaved = GetScore();
        if (_score > scoreSaved)
        {
            PlayerPrefs.SetInt("bestScore", _score);
        }
    }

    private int GetScore()
    {
        return PlayerPrefs.GetInt("bestScore");
    }
    
}
