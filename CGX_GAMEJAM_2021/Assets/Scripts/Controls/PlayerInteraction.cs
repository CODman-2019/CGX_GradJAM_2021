using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    //public KeyCode interaction;

    public Interactables interactable;
    private PlayerInteract interact;

    private void Awake()
    {
        interact = new PlayerInteract();
        interact.Player_Input.Interaction.performed += ctx => InteractWithItem();

    }

    

    // Update is called once per frame
    void InteractWithItem()
    {
            if (interactable)
            {
                interactable.Interact();
            ObjectiveManager.objectiveManager.CheckObjectives();
        }
        
    }

    private void OnEnable()
    {
        interact.Player_Input.Enable();
    }

    private void OnDisable()
    {
        interact.Player_Input.Disable();
    }
}
