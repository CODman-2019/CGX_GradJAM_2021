using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactables : MonoBehaviour
{
    public string prompt;
    public Text display;
    private bool completed;

    // Start is called before the first frame update
    void Start()
    {
        completed = false;
    }

    private void Reset()
    {
        completed = false;
    }

    public void Interact()
    {
        completed = true;
    }

}
