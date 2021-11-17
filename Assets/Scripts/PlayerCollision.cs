using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //reference to our movement script.
    public PlayerMovement movement;
    
    //will be called on collision if object as a rigid body and a collider
    void OnCollisionEnter(Collision collisionInfo) {
        
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    } 

}
