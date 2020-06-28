using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour, InteractableObject
{
    [SerializeField]
    private Animation pivotAnimations;

    [SerializeField]
    private string tooltip;

    [SerializeField]
    private bool lockedDoor = false;

    [SerializeField]
    private string doorCode = "0000";

    [SerializeField]
    private Text doorCodeInput;

    private bool open = false;

    public void interact()
    {
        if(lockedDoor == true)
        {
            if (doorCodeInput.text == doorCode && open == false)
            {
                openDoor();
            }
            else
            {
                tooltip = "press 'e' to open - incorrect code";
            }
        } else if (open == false)
        {
            openDoor();
        }
        
        
    }

    public string getTooltip()
    {
        return tooltip;
    }

    private void openDoor()
    {
        Debug.Log("Door interacted with!");
        pivotAnimations.Play("doorOpen");
        open = true;
        tooltip = "";
    }
}
