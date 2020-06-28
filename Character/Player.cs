using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlaying = false;
    
    public GameObject flashLight;
    public bool hasflashLight;
    public bool flashLightActive = false;

    public GameObject endGameUI;

    private bool endGame = false;

    
    public void giveFlashlight(bool flashlight)
    {
        if(flashlight == true)
        {
            Debug.Log("Flashlight!");
            flashLight.SetActive(true);
            hasflashLight = true;
            flashLightActive = true;
        } else
        {
            flashLight.SetActive(false);
            hasflashLight = false;
            flashLightActive = false;
        }
    }

    public void toggleFlashLight()
    {
        if(hasflashLight)
        {
            if(flashLightActive = false)
            {
                flashLight.SetActive(true);
                hasflashLight = true;
                flashLightActive = true;
            } else
            {
                flashLight.SetActive(true);
                hasflashLight = true;
                flashLightActive = true;
            }
        }
    }

    void OnTriggerEnter(Collider endGame)
    {
        //EndGame
        if(endGame.tag == "EndGame")
        {
            endGameUI.SetActive(true);
            Cursor.visible = true;
            Debug.Log("Game ended!");
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void setIsPlaying(bool playing)
    {
        this.isPlaying = playing;
    }

    public bool getIsPlaying()
    {
        return this.isPlaying;
    }
}
