using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 70f;
    public Transform playerBody;
    private float xRoration = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity *  Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRoration -= mouseY;

        xRoration = Mathf.Clamp(xRoration, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRoration, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
