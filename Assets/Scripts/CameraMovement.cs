using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public float mouseSens = 2.0f;
    private float verticalRotation = 0;
    // private float horizontalRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens;

        verticalRotation -= mouseY;
        //horizontalRotation += mouseX;   

        transform.localEulerAngles = 
            Vector3.right * verticalRotation /*+ Vector3.up * horizontalRotation*/;
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
