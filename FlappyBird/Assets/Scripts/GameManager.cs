using UnityEngine;
using UnityEngine.SceneManagement;

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
                FindFirstObjectByType<ScoreManager>().SaveScore();
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
    
}
