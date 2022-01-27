using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //reference to our movement script.
    public PlayerMovement movement;

    //will be called on collision if object has a rigid body and a collider
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.DisableMovement();
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
