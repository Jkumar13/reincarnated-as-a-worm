using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmovementScript : MonoBehaviour
{
    public Transform player;
    Vector2 velocity = Vector2.zero;

    // Global Variables
    public int playerSpeed;
    public Vector2 targetPosition;
    private Vector3 mouse_pos;
    public Vector2 startingPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse_pos = Input.mousePosition;

        targetPosition = Camera.main.ScreenToWorldPoint(mouse_pos);
        //transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * playerSpeed);
        transform.position = new Vector3(player.position.x, player.position.y,transform.position.z);
    }
}
