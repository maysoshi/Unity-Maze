// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class boxMovement : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject welcomeText; // Reference to the welcome text GameObject
    private bool welcomeTextVisible = true;
    public GameObject fallText; // Reference to the welcome text GameObject

    
    //public float zVelocity = 500f;
    //public float xVelocity = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        rb.useGravity = true;
        rb.AddForce(0, 100, 100);
        fallText.SetActive(false);
    }

    public float moveSpeed = 5f; // Movement speed
    public float turnSpeed = 10f; // Turning speed

    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") != 0f || Input.GetAxis("Horizontal") != 0f)
        {
            // If the welcome text is still visible, hide it
            if (welcomeTextVisible)
            {
                welcomeText.SetActive(false);
                welcomeTextVisible = false;
            }

            // Movement
            float verticalInput = Input.GetAxis("Vertical"); // Get vertical input (W/S or Up/Down arrow keys)
            Vector3 movement = transform.forward * verticalInput * moveSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + movement);

            // Rotation
            float horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrow keys)
            float turn = horizontalInput * turnSpeed * Time.deltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        
        }

        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().endGame();
        }

    }

    //// Collision detection
    //void OnCollisionEnter(Collision collision)
    //{
    //    // Check if the collided object is tagged as an obstacle
    //    if (collision.gameObject.CompareTag("Obstacle"))
    //    {
    //        // Restart the game
    //        FindObjectOfType<GameManager>().endGame();
    //    }
    //}

    //// Detect falling off the platform
    //void Update()
    //{
    //    if (rb.position.y < -1f)
    //    {
    //        FindObjectOfType<GameManager>().endGame();
    //    }
    //}

}
