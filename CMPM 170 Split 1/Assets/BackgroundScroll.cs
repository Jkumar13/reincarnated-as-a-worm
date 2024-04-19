using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundScroll : MonoBehaviour {
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
    public int playerSpeed;


    //variables from playerMovement.cs
    public int playerSpeed;
    public Vector2 targetPosition;
    private Vector3 mouse_pos;
    public Vector2 startingPoint;

    void Start(){
        mat = GetComponent<Renderer>().material;
    }

    void Update(){
        offset += (Time.deltaTime * scrollSpeed) / 10f;

        //EDIT so only scrolls as player is moving
        
        //mat.SetTextureOffset("_MainTex", new Vector2(0, offset));

        transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), Time.deltaTime * playerSpeed);
    }

}