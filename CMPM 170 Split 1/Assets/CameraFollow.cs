using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;


    // Update is called once per frame
    private void Update()
    {
        //NOTE, TO GET THIS WORKING ATTACH THIS TO THE MAIN CAMERA AND SET IT TO FOLLOW SPECIFICALLY THE PLAYER
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
