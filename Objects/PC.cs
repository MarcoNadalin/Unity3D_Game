using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour, InteractableObject
{
    [SerializeField]
    private GameObject monitorUi;

    [SerializeField]
    private string hint;

    [SerializeField]
    private bool on = false;

    void Awake()
    {
        monitorUi.SetActive(on);
    }

    public void interact()
    {
        //Toggle monitor on and off
        on = !on;
        monitorUi.SetActive(on);
    }

    public string getTooltip()
    {
        return hint;
    }
}
