using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public MouseLook mouseLook;
    public Interaction interaction;
    public Move move;

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Lock camera
        if(Input.GetKeyDown("f"))
        {
            mouseLook.toggleCameraLock();
        }

        //Interact
        if(Input.GetKeyDown("e"))
        {
            interaction.interact();
        }

        //Toggle flashlight
        if(Input.GetKeyDown("q"))
        {
            player.toggleFlashLight();
        }

        //Crouch
        if(Input.GetKeyDown("c"))
        {
            move.crouch();
        }

    }
}
