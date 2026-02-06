
using UnityEngine;
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
      GameManager.currentGameState = GameManager.GameState.Restart;

   }

   void TaskOnClick()
   {
      
      RestartGame();
      
   }
}
