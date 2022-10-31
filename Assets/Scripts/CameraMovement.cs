using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private float verticalInput;
    private float horizontalInput;
    private float speed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.position += verticalInput * Vector3.up * speed * Time.deltaTime;
        transform.position += horizontalInput * Vector3.right * speed * Time.deltaTime;
    }
}
