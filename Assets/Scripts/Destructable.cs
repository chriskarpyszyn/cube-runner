using UnityEngine;

public class Destructable : MonoBehaviour
{

    public GameObject destroyedVersion;

    //called when rigid body collides with another
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log("Test");
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
