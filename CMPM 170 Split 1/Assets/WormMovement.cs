using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WormMovement : MonoBehaviour
{
    // Global Variables
    public int playerSpeed;
    public int wormOffset;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPosition = new Vector2(target.transform.position.x, target.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * playerSpeed);
        transform.rotation = target.transform.rotation;

        // transform.rotation = Quaternion.Euler(0, 0, targetPosition * playerSpeed/5);
    }

 

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            // idk
        }
    }
}
