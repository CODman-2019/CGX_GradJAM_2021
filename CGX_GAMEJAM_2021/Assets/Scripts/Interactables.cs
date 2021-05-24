using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactables : MonoBehaviour
{
    public string prompt;
    public Text display;
    public bool isFinal;

    private bool completed;

    // Start is called before the first frame update
    void Start()
    {
        completed = false;
    }

    public bool TaskCheck() => completed;

    public void Interact()
    {
        ObjectiveManager.objectiveManager.CheckObjectives();
        completed = true;
        display.text = null;

        if (isFinal)
        {
            MenuManager.menu.ShowVictory();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if ( !completed)
            {
                other.gameObject.GetComponent<PlayerInteraction>().interactable = this;
                display.text = prompt;
            }
            else
            {
                display.text = null;
                other.gameObject.GetComponent<PlayerInteraction>().interactable = null;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            display.text = null;
            other.gameObject.GetComponent<PlayerInteraction>().interactable = null;
        }
    }
}
