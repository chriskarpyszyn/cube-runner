using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
  
  void OnTriggerEnter() {

      //todo-ck check if the player collides and nothing else
      gameManager.CompleteLevel();
  }

}
