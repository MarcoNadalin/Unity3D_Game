using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{

    private RaycastHit hit;

    [SerializeField]
    private Player player;

    [SerializeField]
    private Camera camera;

    [SerializeField]
    private float interactionDistance = 10f;

    [SerializeField]
    private string interactionTag = "interactable";

    [SerializeField]
    private Text playerHintText;

    [SerializeField]
    private GameObject playerHintObject;

    // Start is called before the first frame update
    void Start()
    {
        playerHintObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Update the player hint text depending on what the player is looking at.
        if(player.getIsPlaying())
        {
            Transform cameraTransform = camera.transform;
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, interactionDistance) && hit.transform.gameObject.tag == interactionTag)
            {
                MonoBehaviour[] list = hit.collider.gameObject.GetComponents<MonoBehaviour>();

                foreach (MonoBehaviour mb in list)
                {
                    if (mb is InteractableObject)
                    {
                        InteractableObject interactbale = (InteractableObject)mb;
                        playerHintText.text = interactbale.getTooltip();
                        playerHintObject.SetActive(true);
                    }
                }
            }
            else
            {
                playerHintObject.SetActive(false);
            }
        }
        
    }

    public void interact()
    {
        Transform cameraTransform = camera.transform;
        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, interactionDistance) && hit.transform.gameObject.tag == interactionTag)
        { 
            MonoBehaviour[] list = hit.collider.gameObject.GetComponents<MonoBehaviour>();

            foreach (MonoBehaviour mb in list)
            {
                if (mb is InteractableObject)
                {
                    InteractableObject interactbale = (InteractableObject)mb;
                    interactbale.interact();
                }
            }
        }
    }
}
