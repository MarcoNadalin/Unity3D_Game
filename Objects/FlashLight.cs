using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour, InteractableObject
{
    public Player player;
    public string tip;

    public GameObject flashlightWorldModel;

    public void interact()
    {
        player.giveFlashlight(true);
        flashlightWorldModel.SetActive(false);
    }

    public string getTooltip()
    {
        return tip;
    }
}
