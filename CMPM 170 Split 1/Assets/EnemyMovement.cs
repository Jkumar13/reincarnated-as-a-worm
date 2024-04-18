using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour{
    public float moveSpeed = 5;
    public int directionX = 1;
    public int directionY = 0;
    public SpriteRenderer mySpriteRenderer;

    void Start(){

    }

    void Update(){
		transform.Translate(directionX*moveSpeed*Time.deltaTime, directionY*moveSpeed*Time.deltaTime, 0);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Boundary")) {
            directionX *= -1;
            directionY *= -1;
            if (mySpriteRenderer.flipY == true) {
                mySpriteRenderer.flipY = false;
            }
            else if (mySpriteRenderer.flipY == false) {
                mySpriteRenderer.flipY = true;
            }
        }
    }
}