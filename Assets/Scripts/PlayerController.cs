using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1000.0f;
    public Rigidbody playerRb;
    public float horizontalInput;
    public float verticalInput;
    float jumpForce = 200.0f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * verticalInput * speed);
        playerRb.AddForce(Vector3.right * horizontalInput * speed);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            playerRb.AddForce(Vector3.up * jumpForce * Time.deltaTime);
        }
    }

}
