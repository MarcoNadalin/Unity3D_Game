using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour, InteractableObject
{
    public string tooltip;

    public void interact()
    {
        Debug.Log("Monitor Interacted with!");
    }

    public string getTooltip()
    {
        return tooltip;
    }
}
