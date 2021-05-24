using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager menu;

    public string text;
    public Text prompt, counter;

    private void Awake()
    {
        menu = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void UpdateCounter(int num)
    {
        if (num == 0)
        {
            counter.text = "GO TO BED!!!";
        }
        else { counter.text = num.ToString(); }
    }

    public void ShowVictory()
    {
        prompt.text = text;
    }
}
