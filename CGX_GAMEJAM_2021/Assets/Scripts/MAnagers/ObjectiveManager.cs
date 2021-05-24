using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public static ObjectiveManager objectiveManager;
    public Interactables[] tasks;
    public Interactables finalTask;

    // Start is called before the first frame update
    void Start()
    {
        objectiveManager = this;
        CheckObjectives();
        finalTask.gameObject.SetActive(false);
    }

    private void EnableFinalTask()
    {
        finalTask.gameObject.SetActive(true);
    }

    public void CheckObjectives()
    {
        
        //if (finalTask.enabled && finalTask.TaskCheck())
        //{
        //    UIManager.ui.ReturnToResults();
        //}

        int missed = 0;

        foreach(Interactables objective in tasks)
        {
            if (!objective.TaskCheck())
            {
                missed++;
            }
            //else
            //{
            //    allCompleted = true;
            //}
        }

        MenuManager.menu.UpdateCounter(missed);

        if (missed == 0)
        {
            EnableFinalTask();
        }

        else if (finalTask.TaskCheck())
        {
            MenuManager.menu.ShowVictory();
        }
        
    }


}
