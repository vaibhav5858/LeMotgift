using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Camera_mouse_movement : MonoBehaviour
{
    public float mouseSensitivity = 50f;

    public Transform PlayerBody;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -55f, 50f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);

    }
}
