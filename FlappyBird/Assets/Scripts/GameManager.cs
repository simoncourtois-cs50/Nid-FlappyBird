using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    public enum GameState
    {
        Playing,
        GameOver
    };

    public static GameState currentGameState;

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
                Time.timeScale = 0f;
                gameOverMenu.SetActive(true);
            break;
            
            case GameState.Playing:
                //Playing
                break;
        }
    }
}
