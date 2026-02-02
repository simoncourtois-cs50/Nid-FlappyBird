
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   public Button yourButton;

   private void Start()
   {
      Button btn = yourButton.GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
   }

   void RestartGame()
   {

      Time.timeScale = 1.0f;
      GameManager.currentGameState = GameManager.GameState.Playing;
      SceneManager.LoadScene("Game");
   }

   void TaskOnClick()
   {
      Debug.Log("Click");
      RestartGame();
      
   }
}
