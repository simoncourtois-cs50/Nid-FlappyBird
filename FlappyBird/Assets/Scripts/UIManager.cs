
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   public Button yourButton;

   public GameManager m_gameManager;
   private void Start()
   {
      Button btn = yourButton.GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
   }

   void RestartGame()
   {
      GameManager.currentGameState = GameManager.GameState.Restart;

   }

   void TaskOnClick()
   {
      
      RestartGame();
      
   }
}
