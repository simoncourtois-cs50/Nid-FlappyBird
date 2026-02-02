using UnityEngine;

public class GameManager : MonoBehaviour
{
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

    public void UpdateStates()
    {
        switch (currentGameState)
        {
            case GameState.GameOver:
                //Game Over
            break;
            
            case GameState.Playing:
                //Playing
                break;
        }
    }
}
