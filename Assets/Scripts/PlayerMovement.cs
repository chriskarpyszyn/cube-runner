using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // This is a refernece to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 8000f;
    public float sidewaysForce = 120f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144;
    }

    // Update is called once per frame
    // We marked this as FixedUpdate because we are using it with Unity Physics
    //todo-ck better to check for input in the update method and set a bool to update in fixedUpdate
    void FixedUpdate()
    {
        // Add a foeward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //todo-ck there is a better way to handle input in unity
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //todo-ck don't hardcode numbers
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
