using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public KeyCode interaction;

    private Interactables interactable;

    // Start is called before the first frame update
    void Start()
    {
        interactable = null;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(interaction))
        {
            if (interactable)
            {
                interactable.Interact();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            interactable = other.gameObject.GetComponent<Interactables>();
        }
        else { interactable = null; }
    }
}
