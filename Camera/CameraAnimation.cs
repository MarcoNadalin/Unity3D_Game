using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
    public Camera camera;

    public Vector3 destinationPosition;
    public Vector3 destinationRotation;


    public float animationSpeed = 1;

    public bool startAnimation = false;

    // Update is called once per frame
    void Update()
    {
        if(startAnimation == true)
        {
            //Change camera position
            camera.transform.localPosition = Vector3.MoveTowards(camera.transform.localPosition, destinationPosition, animationSpeed);

            //Change camera rotation
            //Quaternion.RotateTowards(camera.transform.Localrotation, target.rotation, step);
        }        
    }

    public void startAnim()
    {
        this.startAnimation = true;
    }
}
