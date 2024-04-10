using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Global Variables
    public int playerSpeed;
    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            velocity.x = playerSpeed;
        }
        else if (Input.GetKey(KeyCode.A)) {
            velocity.x = -playerSpeed;
        }
        else {
            velocity.x = 0;
        }
        if (Input.GetKey(KeyCode.W)) {
            velocity.y = playerSpeed;
        }
        else if (Input.GetKey(KeyCode.S)) {
            velocity.y = -playerSpeed;
        }
        else {
            velocity.y = 0;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = transform.position;
        
        position.x += velocity.x * Time.fixedDeltaTime;
        position.y += velocity.y * Time.fixedDeltaTime;
        
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            // idk
        }
    }
}
