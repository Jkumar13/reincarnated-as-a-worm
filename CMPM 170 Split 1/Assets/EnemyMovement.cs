using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour{
    public float moveSpeed = 5;
    public float moveDistance = 50;
    public Vector2 currentPoint;
    public int direction = 1;

    void Start(){

    }

    void Update(){
		transform.position = Vector2.MoveTowards(transform.position, currentPoint * direction, Time.deltaTime * moveSpeed);
        if (transform.position.x >= currentPoint.x) {
            direction = -1;
        }
        if (transform.position.x <= -currentPoint.x) {
            direction = 1;
        }
    }
}