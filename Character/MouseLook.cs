using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 50f;
    public Transform player;

    public bool lockCamera = false;
    public bool cursor = true;

    public float maxXRotation = 90f;

    private float xRotation = 0f;


    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = cursor;
    }

    // Update is called once per frame
    void Update()
    {
        if(lockCamera == false)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -maxXRotation, maxXRotation);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            player.Rotate(Vector3.up * mouseX);
        }
       
    }

    public void toggleCameraLock()
    {
        if(this.lockCamera == true)
        {
            this.lockCamera = false;
            cursor = false;
            Cursor.visible = cursor;
        } else
        {
            this.lockCamera = true;
            cursor = true;
            Cursor.visible = cursor;
        }
    }

    public void unlockCamera()
    {
        this.lockCamera = false;
        cursor = false;
        Cursor.visible = cursor;
    }
}
