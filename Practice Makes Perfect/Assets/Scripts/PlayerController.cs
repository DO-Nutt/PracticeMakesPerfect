using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 10.0f;
    public float horizontalInput;
    public float velocity = 10.0f;
    public Rigidbody playerRigidBody;
    
    

    // Update is called once per frame
    void Update()
    {
        // Allows player horizontal movement on button press
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Applies vertical force to jump on space bar click
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidBody.velocity = Vector2.up * velocity;
        }

    }
}
