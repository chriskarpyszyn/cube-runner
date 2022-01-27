using UnityEngine;

public class DetectionZoneTrigger : MonoBehaviour
{ 
    public GameManager gameManager;
    public PlayerMovement playerMovement;

    void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.gameObject.CompareTag("Destructable"))
        {
            gameManager.EndGame();
        }
    }
}
