using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Global Variables
    public int playerSpeed;
    public Vector2 targetPosition;
    private Vector3 mouse_pos;
    
    // Start is called before the first frame update
    void Start()
    {

        // Ansh was here
        // Jay was here.
    }

    // Update is called once per frame
    void Update()
    {

        mouse_pos = Input.mousePosition;

        targetPosition = Camera.main.ScreenToWorldPoint(mouse_pos);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * playerSpeed);
    }

 

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            // idk
        }
    }
}
